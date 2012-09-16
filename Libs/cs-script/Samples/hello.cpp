#pragma comment(lib, "User32.lib")
//css_ref System.Windows.Forms;

#include "windows.h"
using namespace System;
using namespace System::Windows::Forms;

public ref class Script
{
	public: 
		static void Main()
		{
			Console::WriteLine(L"Hello World! (C++)");
			MessageBoxA(0, "Hello World! (C++)", "Non-Managed", 0);
			MessageBox::Show("Hello World! (C++)", "Managed");
		} 
};
