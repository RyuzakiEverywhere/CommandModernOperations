   M S B A M L   `   `   `  ???? B  >Command, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CommandCommand  %    Command.TerrainTypeLegendWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D @WpfBindTo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Command     -     ? 
ResizeMode$  CanResizeWithGrip=? ? WindowStyle$
 None=?$	??224??$	??704??.???? 
??????? ? 	Resources    TerrainTypeData ? XPath??%C  &	        ? $ Data/TerrainTypes??.????<Data xmlns="">
                        <TerrainTypes>
                            <Terrain Color="#000080" Header="Water" />
                            <Terrain Color="#008000" Header="Evergreen Needleleaf Forest" />
                            <Terrain Color="#00FF00" Header="Evergreen Broadleaf Forest" />
                            <Terrain Color="#99CC00" Header="Deciduous Needleleaf Forest" />
                            <Terrain Color="#99FF99" Header="Deciduous Broadleaf Forest" />
                            <Terrain Color="#339966" Header="Mixed Forest" />
                            <Terrain Color="#993366" Header="Closed Shrubland" />
                            <Terrain Color="#FFCC99" Header="Open Shrubland" />
                            <Terrain Color="#CCFFCC" Header="Woody Savannas" />
                            <Terrain Color="#FFCC00" Header="Savannas" />
                            <Terrain Color="#FF9900" Header="Grasslands" />
                            <Terrain Color="#006699" Header="Permanent Wetlands" />
                            <Terrain Color="#FFFF00" Header="Croplands" />
                            <Terrain Color="#FF0000" Header="Urban and Built-Up" />
                            <Terrain Color="#999966" Header="Cropland Natural Vegetation Mosaic" />
                            <Terrain Color="#FFFFFF" Header="Snow and Ice" />
                            <Terrain Color="#808080" Header="Barren or Sparsely Vegetated" />
                        </TerrainTypes>
                    </Data>        ????  ?? Source# [   ?? XPath$ Terrain?????? .R??  K? IsItemsHost .  ? Orientation$ Vertical=????? .R??? 
???????$	??1.9q? ?? Padding$ 3q?
???????$??3q?._??? 	 ?? Orientation$	 
Horizontal=?.+??? $??14??$??14?????? 
 ?? Color
 ?? $ @Color???? $??12(?$??3,0,0,0q????? $ @Header??