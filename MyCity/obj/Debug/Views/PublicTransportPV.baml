   M S B A M L   `   `   `  ����A  =MyCity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MyCity.ViewsMyCity.Views  5      5clr-namespace:MyCity.ViewModelsMyCity.ViewModels  5      $    MyCity.Views.PublicTransportPV   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MyCity.Views     5      .vmclr-namespace:MyCity.ViewModels     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5        $��Window��5
   8     � 	Resources  5         btnTemplate �� 
TargetType �� CornerRadius �� TextAlignment �� Triggers P� Property P� Value �� 
TargetName �� Property	 �� Value  ListBoxTemplate��%  &	        &	      �� 5   
   " ��6.   .R�5      �� $��	btnBorder��5      
��� d �$��70��5      $��70��5      $	 100��5      ._�5      �� $��20(�5      #��z��5      
�������$ Center=�5      $��Center=�5      $��Center=�5      5      5       5      P� 5       �@J�IsMouseOver . . �5       �� $ 	btnBorder��6    � ��
	 � � �6J   5!      P� 5"       � �� . . �5#      �� $ 	btnBorder��6    � ��
	 � � �6J   5$      5&      �� 5(   
   .R�5)      ]� .+�5*      �� $	��150��61   $	��150��6>   ��6   �� *Image+6>   �� 5+      $��30(�6   $	��Top=�6&   ��6;   �� *Header+�� 5,      $��15(�6   $��Bottom=�6&   ��6>   �� *
DateTime+5-      5.      5/      .��50      �� 
�������.+�51   
   � $	��150��6   
�������
 � ColumnDefinitions
 52      �� 53      $	��150 �6#   �� 54      .+�56      �� ���#0C7C66$	��150��58      ���#0C7C66$��0q�5:      
���������5<      �� *BackCommand+.��5=      '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�5>      $��Center=�5?      $��0��5@      �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ Information=�5A      $��50��5B      $��50��5C      5D      �� 5E      $��1��5F      $��Bottom=�5G      $��20,0,0,0q�5H      $
��INFO��5I      $��Champagne & Limousines)�5J      $��50(�5K      5L      �� 5M   
   
�������$	��430��5O      $��Stretch=�5P      $��20(�5Q      #��[ 5S      ��5R      �� *PublicTransport+5S      �� 5T   
   $��80��5U      #��[  5V      $
��🔃��5W      ��5X      �� *RefreshCommand+5Y      5Z      