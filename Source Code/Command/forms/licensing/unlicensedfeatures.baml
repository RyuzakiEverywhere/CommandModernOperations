   M S B A M L   `   `   `  ???? B  >Command, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CommandCommand  &     Command.UnlicensedFeaturesWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D @WpfBindTo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Command       ? Topmost  .  ? Title$ UnlicensedFeatures??$	??400??$	??500?? ? WindowStyle$
 None=? ? 
ResizeMode$ NoResize=? ? WindowStartupLocation$ CenterScreen=? ? AllowsTransparency . $??15q?$??15q????#3B3F42 ? SizeToContent$ Height=?.????  ?? CornerRadius$ 25??$	??2.5q? ?? Padding$ 15q?
???????$??15q?._?? 	 ? RowDefinitions	 ?? $
??auto ??? $??* ??? $
??auto ?.+??? -   $??2??$??Center=?
?????? $??5q?.???? $??	Underline{?
???????Return to Scenario Selection?? $??0??$??Center=?$
??Bold"?$
??Wrap=?
???????0.This scenario requires the following features:?? $??12q?$??1?????? *Items+???? .R??? ???? .R?? $??1q?
 J? Effect
 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 15Q?   ShadowDepth$ 5Q?.+?]? .+??? $
??Left=?$??25??$??0,0,5,0q????? *	LockImage+?? $??1q?$ 2??._??? $??1q?
???????$ 10??$ 5q?._??  ? ColumnDefinitions ?? .+??? 
??????????? *Title+?? $??Right=?
?????? 
?????? ???? *UnlockCommand+.???? $??	Underline{?
???????Unlock