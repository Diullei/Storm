CS-Script allows post-processing of compiled scripts just before the execution by means of pluggable PostProcessor components.
One of such PostProcessors is the CSSPostSharp.dll assembly included with the CS-Script distributables. This assembly allows injection of the PostSharp aspects for scripts being executed.

Precondition:
 PostSharp v1.5+ must be installed. You can download  PostSharp setup from http://www.postsharp.org/.

PostSharp support activation instructions:
 - Start Configuration Console and set PostProcessor path to assembly path: UsePostProcessor=%CSSCRIPT_DIR%\Lib\CSSPostSharp.dll
 - Set environment variable CSS_POSTSHARP to the PostSharp installation dir (e.g. C:\Program Files\PostSharp 1.5\). 
   Note: this step is optional but if you do not set CSS_POSTSHARP CS-Scrip will use the first PostSharp binaries found in the "Program Files".
  
Limitations:
 - CS-Script support for PostSharp was implemented and tested for PostSharp v1.5. Thus the future versions of PostSharp may not have the same command-line interface and may require adjustments of the CSSPostSharp.dll assembly.  
 
Samples:
<cs-script>Samples\PostSharp\script.cs sample demonstrates how you can inject aspect for tracing all calls to the methods of the System.Threading namespace. 