   M S B A M L   `   `   `  ����A  =MyCity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MyCity.ViewsMyCity.Views  5      5clr-namespace:MyCity.ViewModelsMyCity.ViewModels  5          MyCity.Views.BuildingView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MyCity.Views     5      .vmclr-namespace:MyCity.ViewModels     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      � 
�������  � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      .+�5   
   �  � ColumnDefinitions 5      �� 5      $	��100 �6#   �� 5      .+�5      �� $��20(�5      $
��Back��5      $��50��5      ���#11397E
�������$��Champagne & Limousines)�5      ��5      �� *BackCommand+5      � 5    
   $��1��6   $��20,0,0,0q�6    5!      �� 5"      $	��300 �6#   �� 5#      .+�5%      �� $��0��6   .+�5&      �� $
��0,10q�6   $��25(�6&   $��Image:��64   �� 5'      $
��0,20q�6   $	��270��6?   $	��270��6L   ��6&   �� *Image+6L   �� 5(      $
��0,10q�6   ���#4169E1$��70��6<   $��20(�6H   $��BROWSE��6V   ��6g   �� *BrowseCommand+5)      �� 5*      $��1��6   .+�5+      �� $
��0,10q�6   $��25(�6&   $��Title:��64   �� 5,      $��15(�6   ��6(   �� *Building.Header+�� 5-      $
��0,10q�6   $��25(�6&   $��Text:��64   �� 5.       �� TextWrapping$
 Wrap=�6   $��15(�6.   ��6<   �� *Building.Text1+�� 5/      $
��0,10q�6   $��25(�6&   $��Date:��64   (  "System.Windows.Controls.DatePicker  50      $	��300��51      $
��Left=�52         SelectedDateFormat$ Short=�53         IsTodayHighlighted .    SelectedDate 55      �� *Building.DateTime1+A� 57      .+�58      �� $��20,110q�59      $
��Left=�5:      ���#4169E1$��70��5<      $	��300��5=      $��25(�5>      $
��Send��5?      ��5@      �� *SendCommand1+�� 5A      ���#4169E1$��70��5C      $	��300��5D      $��25(�5E      $��Watch Problems��5F      $��Right=�5G      $��20,110q�5H      ��5I      �� *WatchProblemCommand+5J      5K      5L      5M      5N      