   M S B A M L   `   `   `  ???? B  >Command, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CommandCommand  "    Command.RealismDialogControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D @WpfBindTo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Command       ? 	Resources  *   $Command.BooleanToVisibilityConverter    BooleanToVisibilityConverter1   +Command.InverseBooleanToVisibilityConverter ' #InverseBooleanToVisibilityConverter?? %   &	        &	          .??]? ???#4C4C4C.+??? $	??200??$??50??$	??Top=?$??20q?$??Bottom=????? *	OKCommand+???? $??15,0,0,0q?.+??? $??Begin Scenario??$??20(??? $??12(????#3f3f3f???? *ScenarioLength+????  ?? 
TargetType" ??.???  ?? Property ? ?? ?? Value ?#373737??  ? ??
 ???????  ? ??$ 15(???  ?@J?SnapsToDevicePixels . ??  ? ?? ??  ?? 
TargetType" ??.R???  ?? CornerRadius$ 12??#??z??._?? .+?F?  F?Name$ PathIcon??$??15??$??25?? ?? Stretch$
 Fill=????#4C87B3$
??Left=?$??17,0,0,0q?4???????<R???=?x?O???Tn5????<R??  ??Name$ MyContentPresenter??#??z??$??Center=?$??Center=?$??0,0,0,0q?	 ?? Triggers	 P? 
 P? Property
 ?@J?IsMouseOver P? Value . . ???  ? ?? ?#E59400??  ? ??
 ???????  ?? 
TargetName$ PathIcon?? ? ??
 ?   ?P? 
 ? ?? . . ???  ? ??
 ? E????  ? ??
 ??????? $??0,0,0,0q????? *Items+???? .R??? 
??????$??2q?$??1,1,1,1q????#435159$ 12??$??50??._?? $??3q? ? RowDefinitions ?? ??  ? ColumnDefinitions ?? $??* ??? $??50 ?.+??? $??0??$??16(?
???????$
??Bold"????? *Title+ J? Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 0Q?   
BlurRadius$ 4Q?   Color$ White???? $??1??$
??Wrap=?
??????????? *
Subtitle+?? $??1??$ 50??$??40??$??40??$??2?? ?? Padding$ 6q?y??? *Active+ ?? 	Converter# [  ._??? ???? *PositiveImageSource+?? $??1??$ 50??$??40??$??40??$??2??$ 6q?y??? *Active+# [ ._??? ???? *NegativeImageSource+