   M S B A M L   `   `   `  ???? B  >Command, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CommandCommand  !    Command.StartGameMenuWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D @WpfBindTo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Command     -     ? WindowStyle$
  None=? ? ShowInTaskbar .   ? 	Resources  ?? MergedDictionaries ?? Source??  ?? $0 */Command;component/WPF/ExpressionDark.xaml??%    .??? .+??  ? RowDefinitions ?? $??* ??? $
??auto ??? $??* ? ? ColumnDefinitions ?? $??* ??? $
??auto ??? $??* ?.+?r? -   $??myMediaElement?? r? Stretch$
 Fill=?$??3??$??3?? r? Source$% Symbols\StartMenu\GlobeLoop.mp4???? -   	 ??Name$	 
FirstFrame??$??3??$??3??

 ? Tag$&
  Symbols\StartMenu\FirstFrame.jpg??$
??Fill=?$??Stretch=?$??Stretch=?(? $??Stretch=? (? StretchDirection$
 Both=?$??Stretch=?.???  ?? $??* ??? $
??auto ??? $??* ? ?? $??* ??? $
??auto ??? $??* ?.+?? $??1??$??1??  ?? 
TargetType ?? Property ?? Value ?? BasedOn ?? Triggers P? Property P? Value N? EnterActions g? Duration ?? TargetProperty ?? From	 ?? To N? ExitActions ?? Color    DarkUI_VerticalGradientBrush  NuclearButtonFocusVisual  NormalBorderBrush  DarkUI_ButtonTemplate??%  '??       '?? @     '?? k    ?? " ??.???  ? ??$ 5,5,5,5q???  ? ??$
 Fill=??? " ?? Z?  P?  ?@J?IsMouseOver .  ?? .???? .???? $ 	0:0:0.250D?$( "Foreground.(SolidColorBrush.Color)?$ WhiteX?$
 CyanX? ?? .???? .???? $ 	0:0:0.250D?$( "Foreground.(SolidColorBrush.Color)?$
 CyanX?$ WhiteX?.???  ? ??$ 	15,5,15,5q???  ? ??$ 15,15,15,15q???  ? ??$ 60????  ? ??$ Segoe UI)???  ? ?? ?? $ White????  ? ??$ 20(???  ? ??$
 Bold"???  ? ??# ?   ??  ?@?FocusVisualStyle# ?  ??  ? ??# ?  ??  ? ??# ?  ?? " ??.???  ? ??$	 250????  ? ??$ 5????  ? ??$ Center=???  ? ??
 ???????  ? ??$ 	15,5,15,5q?.+??? $
??1000??.+??? -   $	 	MainTitle??$+
 %Symbols\StartMenu\Command_dark-bg.png???? -   $??Button_NewGame??$	??400?????? *NewGameCommand+.??Start New Game?? -   $??Button_QuickBattle??$	??400?????? *QuickBattleCommand+.??Quick Battle?? -   $??Button_Campaign??$	??400?????? *StartNewCampaignCommand+.??	Campaigns?? -   $??Divider1??$	??400???? -	   $??Button_LoadGame??$	??400?????? *LoadGameCommand+.??Load Saved Game?? -
   $??Button_ResumeGame??$	??400?????? *ResumeGameCommand+.??Resume From Autosave?? -   $??Divider2??$	??400???? -   $??Label_Loading??$??Italic$?$??Center=?$??24(?.??Loading, please wait...?? -   $??Button_CreateScenario??$	??400?????? *CreateScenCommand+.??Create New Scenario?? -   $??Button_LoadScenario??$	??400?????? *LoadScenCommand+.??Edit Scenario?? -   $??Divider3??$	??400???? -   $??Button_Exit??$	??400?????? *ExitCommand+.??Exit?? -   $??Button_Spacer??$	??400??$y?Hidden=?.??Spacer?? -   $??Label_ProgramTitle??$??Italic$?$??Center=?$??16(?.??Program Title