@CD /D "%~dp0"
@title MvcFolders Command Prompt
@SET PATH=C:\Program Files (x86)\MSBuild\14.0\Bin\;%PATH%
@doskey b=msbuild $* MvcFolders.proj
type readme.md
%comspec%
