   M S B A M L   `   `   `  ����A  =MyCity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MyCity.ViewsMyCity.Views  5      5clr-namespace:MyCity.ViewModelsMyCity.ViewModels  5          MyCity.Views.NewsListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MyCity.Views     5      .vmclr-namespace:MyCity.ViewModels     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��Window��5
   8     � 	Resources  5         btnTemplate �� 
TargetType �� CornerRadius �� TextAlignment �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  ListBoxTemplate
 �� ElementName��%  &	        &	      �� 5   
   " ��6.   .R�5      �� $��	btnBorder��5      
��� d �$��70��5      $��70��5      $	 100��5      ._�5      �� $��20(�5      #��z��5      
�������$ Center=�5      $��Center=�5      $��Center=�5      5      5       5      P� 5       �@J�IsMouseOver . . �5       �� $ 	btnBorder��6    � ��
	 � � �6J   5!      P� 5"       � �� . . �5#      �� $ 	btnBorder��6    � ��
	 � � �6J   5$      5&      �� 5(   
   .R�5)      ]� .+�5*      �� $��Right=�6   $��21(�60   $	��❌��6>   ��5+      �� *DataContext.DeleteCommand+$
 Window����5,      �� �� 5-      $��Right=�6   $��21(�60   $
��👁��6>   $	��300��50      ��5.      �� *DataContext.OpenInfoCommand+$
 Window����5/      �� 50      �� 51      $	��150��61   $	��150��6>   ��6   �� *Image+6>   �� 52      ��6   �� *Header+�� 53      ��6   �� *
DateTime+54      55      56      .��57      �� 
�������.+�58   
   � $	��150��6   
������� � ColumnDefinitions 59      �� 5:      $	��150 �6#   �� 5;      .+�5=      �� ���#0C7C66$	��150��5?      ���#0C7C66$��0q�5A      
���������5C      �� *BackCommand+.��5D      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�5E      $��Center=�5F      $��0��5G      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ 	Newspaper=�5H      $��50��5I      $��50��5J      5K      �� 5L      $��1��5M      $��Bottom=�5N      $��20,0,0,0q�5O      $
��NEWS��5P      $��Champagne & Limousines)�5Q      $��50(�5R      5S      �� 5T   
   
�������$	��430��5V      $��Stretch=�5W      $��20(�5X      #��[ 5Z      ��5Y      �� *News+5Z      �� 5[   
   $��80��5\      #��[  5]      $
��🔃��5^      ��5_      �� *RefreshCommand+5`      5a      