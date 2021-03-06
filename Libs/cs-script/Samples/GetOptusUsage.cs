using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

class Script 
{
	const string usage = "Usage: cswscript GetOptusUsage username:password [/p[:proxyUsername[:proxyPassword]]]...\nGets Optus (www.optus.com.au) data usage. Optionally connect with proxy authentication\n";
	//const string urlTemplate = "https://myaccount.optusnet.com.au/mydatamonitor/usage.txt?login={0}&passwd={1}"; //old
	//https://memberservices.optusnet.com.au/myusage/usage.xml?username=<username>&password=<password> //xml format
	const string urlTemplate = "https://memberservices.optusnet.com.au/myusage/usage.txt?username={0}&password={1}";
	
	static public void Main(string[] args)
	{
		if (args.Length < 1 || (args.Length == 1 && (args[0] == "?" || args[0] == "/?" || args[0] == "-?" || args[0].ToLower() == "help")))
		{
			Console.WriteLine(usage);
		}
		else
		{
			try
			{
				string user = null, pw = null;
				string userPxy = null, pwPxy = null;
				
				//prepare http credentials
				string[] credentials = args[0].Split(":".ToCharArray(), 2);
				user = credentials[0];
				
				if (credentials.Length > 1)
				{
					pw = credentials[1];
				}

				if (pw == null)
				{
					if (!AuthenticationForm.GetCredentials(ref user, ref pw, "Account login"))
					{
						return;
					}
				}
				//prepare proxy credentials
				if (args.Length > 1 && args[1].StartsWith("/p"))
				{
					string[] credentialsPxy = args[1].Split(":".ToCharArray(), 3);
					if (credentialsPxy.Length > 1)
					{
						userPxy = credentialsPxy[1];
					}
					if (credentialsPxy.Length > 2)
					{
						pwPxy = credentialsPxy[2];
					}
					
					if (userPxy == null || pwPxy == null)
					if (!AuthenticationForm.GetCredentials(ref userPxy, ref pwPxy, "Proxy Authentication"))
					{
						return;
					}
				}
				
				string htmlStr = GetHTML(String.Format(urlTemplate, user, pw), userPxy, pwPxy);
				
                string msg = "";
				string title = "";
				using (StringReader strReader = new StringReader(htmlStr)) 
				{
					string line;
					while ((line = strReader.ReadLine()) != null) 
					{
						if (line.StartsWith("plan_limit"))
						{
							msg += "Limit: " + line.Split("=".ToCharArray(), 2)[1] + "\n";
						}
						if (line.StartsWith("usage"))
						{
							msg += "Usage: " + line.Split("=".ToCharArray(), 2)[1] + "\n";
						}
						if (line.StartsWith("username"))
						{
							msg += "User: " + line.Split("=".ToCharArray(), 2)[1] + "\n";
						}
						if (line.StartsWith("plan_name"))
						{
							title = line.Split("=".ToCharArray(), 2)[1] + " Plan";
						}
					}
				}

				MessageBox.Show(msg, title);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}

	static string GetHTML(string url, string proxyUser, string proxyPw)
	{
		StringBuilder sb  = new StringBuilder();
		byte[] buf = new byte[8192];

		HttpWebRequest  request  = (HttpWebRequest)WebRequest.Create(url);
		if (proxyUser != null)
		{
			WebProxy proxyObject = (WebProxy)GlobalProxySelection.Select; 
			request.Proxy = proxyObject;
			proxyObject.Credentials = new NetworkCredential(proxyUser, proxyPw);
		}
		
		HttpWebResponse response = (HttpWebResponse)request.GetResponse();

		Stream resStream = response.GetResponseStream();

		NetworkCredential test = (NetworkCredential)CredentialCache.DefaultCredentials;

		string tempString = null;
		int count = 0;

		while (0 < (count = resStream.Read(buf, 0, buf.Length)))
		{
			tempString = Encoding.ASCII.GetString(buf, 0, count);
			sb.Append(tempString);
		}
		return sb.ToString();
	}


	public class AuthenticationForm : System.Windows.Forms.Form
	{
		public string userName {get {return textBox1.Text;} set {textBox1.Text = value;}}
		public string password {get {return textBox2.Text;} set {textBox2.Text = value;}}

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
			
		private System.ComponentModel.Container components = null;

		public AuthenticationForm(string userName, string password, string title)
		{
			InitializeComponent();
			textBox1.Text = userName;
			textBox2.Text = password;
			if (textBox1.Text != "")
			{
				textBox2.Select();
			}
			if (title != null)
			{
				this.Text = title;
			}
		}

		static public bool GetCredentials(ref string userName, ref string password, string title)
		{
			using(AuthenticationForm dlg = new AuthenticationForm(userName, password, title))
			{
				if (DialogResult.OK == dlg.ShowDialog())
				{
					userName = dlg.userName;
					password = dlg.password;
					return true;
				}
				else 
				{
					return false;
				}
			}
		}
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(40, 80);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 24);
			this.button1.TabIndex = 2;
			this.button1.Text = "&Ok";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(136, 80);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 24);
			this.button2.TabIndex = 3;
			this.button2.Text = "&Cancel";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(80, 40);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(160, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "User Name:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password:";
			// 
			// AuthenticationForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(250, 112);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AuthenticationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Authentication";
			this.ResumeLayout(false);

		}
		#endregion
	}
}