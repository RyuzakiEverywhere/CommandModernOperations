   M S B A M L   `   `   `  ???? B  >Command, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CommandCommand      Command.CargoOpsControl   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D @WpfBindTo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Command       ? 	Resources   ?? MergedDictionaries ?? Source??  ?? $T Npack://application:,,,/Command;Component/WPF/CommandWPFResourceDictionary.xaml???? $0 */Command;component/WPF/ExpressionDark.xaml??%    .???  ? RowDefinitions ?? $??* ??? $
??Auto ?.+??  ? ColumnDefinitions ?? ?? $??5 ??? .+??? $??1??$??5??$??Stretch=?y??? *ExchangeVisibility+? $??0??????  ?? 
TargetType" ?.???  ?? Property ? ?? ?? Value$ 1?? ?? Triggers ?? 	 ?? Binding	 ?? *
Exchange+
 ?? Value	
 False.a???  ? ??$ 3?? ?? $
??Auto ??? $??* ?.+??? .+??? $??Center=????? *
HostName+ ?? FallbackValue$ HostName???  ?? $
??Auto ??? $??* ? ?? ?? ?? .+??? $??0??$??3q?$??3q?.??Mass? $??0??$??1??
???  ?? ? Value ?? *HostRequiredMass+ ? Maximum ?? *HostTotalMass+?? $??0??$??1??$??Center=?
??????? J? Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 5Q?   Color$ Black?????? ??`?  ?? StringFormat$ {0} / {1} tons??.1???  ?? Path$ HostRequiredMass?$
 1000???? $ HostTotalMass?$
 1000???? $??1??$??3q?$??3q?.??Area? $??1??$??1??
??? ? ? ?? *HostRequiredArea+ ?? *HostTotalArea+?? $??1??$??1??$??Center=?
???????   $ 5Q?$ Black?????? ??`? $ {0} / {1} sq. m??.1??? $ HostRequiredArea?$
 1000???? $ HostTotalArea?$
 1000???? $??2??$??3q?$??3q?.??Crew? $??2??$??1??
????  ? ?? *HostRequiredCrew+ ?? *HostTotalCrew+?? $??2??$??1??$??Center=?
???????   $ 5Q?$ Black?????? ??`? $ {0} / {1} men??.1??? $ HostRequiredCrew?$
 1000???? $ HostTotalCrew?$
 1000???? $??1?????? *HostInventory+ ?? SelectedItem ?? *HostSelectedItem+ ?? Mode$ TwoWay=????? .R??? .+??? ???? *Name+???? *CargoTypeLimitedBrush+?? ???? *CargoTypeLimitedBrush+???? ??`? $< 6Mass: {0} tons    Area: {1} sq. m    Crew: {2} men {3}??.1??? $ MassPerUnit??? $ AreaPerUnit??? $ CrewPerUnit??? $ 	Abilities?? $??2??y??? *ExchangeVisibility+ ?? $
??Auto ??? $??* ?.+??? .+??? $??Center=????? *
TargetName+$ 
TargetName???  ?? $
??Auto ??? $??* ? ?? ?? ?? .+??? $??0??$??3q?$??3q?.??Mass? $??0??$??1??
???  ?? ?? *TargetRequiredMass+ ?? *TargetTotalMass+?? $??0??$??1??$??Center=????? ??`? $ {0} / {1} tons??.1??? $ TargetRequiredMass??? $ TargetTotalMass??? $??1??$??3q?$??3q?.??Area? $??1??$??1??
??? ? ? ?? *TargetRequiredArea+ ?? *TargetTotalArea+?? $??1??$??1??$??Center=????? ??`? $ {0} / {1} sq. m??.1??? $ TargetRequiredArea??? $ TargetTotalArea??? $??2??$??3q?$??3q?.??Crew? $??2??$??1??
????  ? ?? *TargetRequiredCrew+ ?? *TargetTotalCrew+?? $??2??$??1??$??Center=????? ??`? $ {0} / {1} men??.1??? $ TargetRequiredCrew?$
 1000???? $ TargetTotalCrew?$
 1000???? $??1?????? *TargetInventory+ ?? *TargetSelectedItem+$ TwoWay=????? .R??? .+??? ???? *Name+???? *CargoTypeLimitedBrush+?? ???? *CargoTypeLimitedBrush+???? ??`? $< 6Mass: {0} tons    Area: {1} sq. m    Crew: {2} men {3}??.1??? $ MassPerUnit??? $ AreaPerUnit??? $ CrewPerUnit??? $ 	Abilities?? $??1??y??? *ExchangeVisibility+.+???  ?? Orientation$ 
Horizontal=?$??Center=?.+??? $ 
Horizontal=?$??Center=?y??? *LoadVisibility+.+??? $??5q?$??5q????? *LoadOneCommand+.??
Load One?? $??5q?$??5q????? *LoadAllCommand+.??
Load All?? $ 
Horizontal=?$??Center=?y??? *UnloadVisibility+.+??? $??5q?$??5q????? *UnloadAllCommand+.??
Unload All?? $??5q?$??5q????? *UnloadOneCommand+.??
Unload One?? $ 
Horizontal=?$??Right=?.+??? $??5q?$??5q?$
??Bold"????? *CancelCommand+.??CANCEL?? $??5q?$??5q?$
??Bold"????? *	OKCommand+.??OK? $??1??y??? *ExchangeVisibilityInverse+.+??? $ 
Horizontal=?$??Right=?