   M S B A M L   `   `   `  ����B  >LAB__20, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LAB__20LAB__20  5   	       LAB__20.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:LAB__20     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ 	sldSource��5       � Value$ 50Q�6$    � Maximum$ 80Q�6/    � Minimum$ 10Q�6<    �� TickFrequency$ 6Q�5       �� TickPlacement$
 Both=�6#   $��0��5      $��5q�6    �� AutoToolTipPlacement$ TopLeft=�6)   � 5   
   $��1��6   	 � ColumnDefinitions	 5      �� 5      $
��Auto �6#   �� 5      �� 5      $
��Auto �6#   .+�5      �� -   5        
 ��Name$
 	listColor��5      $��1��6)   $	��150��69    �� SelectedIndex$ 0��6E   $��
642,-2,0,0q�6W   .@�5      �� $��Фиолетовый��6   
 � Tag$ Purple��63   �� 5      $��Зеленый��6   $ Green��60   �� 5      $��Оранжевый��6   $ Orange��62   �� 5      $��Красный��6   $	 Red��60   �� 5      $��
Синий��6   $
 Blue��6.   5!      �� 5#      -   5         ��Name$ 	txtTarget��5#      $��1��6+    �� TextAlignment$ Center=�5$      $��Center=�6+   ��5%      �� *Value+ �� ElementName$ 	sldSource�� �� Mode$ TwoWay=���5&      �� $ 	listColor�� �� Path$ SelectedItem.Tag���5'      �� *Text+$ txtTextSource���� 5)      
�������$��2��60   $��	0,0,553,0q�6D   .+�5*      � .+�5+      �� -   5         ��Name$ btnCreateBinding��5+      $%��Создать привязку��67   $��5q�5,      $��30��5-      5.      �� 5/      -   5        $ btnDeleteBinding��5/      $%��Удалить привязку��67   $��5q�50      $��30��51      52      53      �� 54      -   5        $
 listFont��54      $ 0��6,   $��0 10 0 0q�55      .@�56      �� $��Times New Roman��6"   $ Times New Roman��6<   �� 57      $��Arial��6"   $ Arial��62   �� 59      $��Palatino Linotype��6"   $ Palatino Linotype��6>   5:      �� 5<      -   5        $
 
listWeight��5<      $ 0��6.   $��0 10 0 0q�5=      .@�5>      �� $��Courier New��6"   $ Courier New��68   �� 5?      $��Regular��6"   $ Regular��64   �� 5@      $
��Bold��6"   $
 Bold��61   5A      5B      5C      �� 5D   
   $��2��6   $��10q�6"   .+�5E      �� -   5         ��Name$ enableButton��5E      $��Включить ввод��6-    d� 	IsChecked$
 TrueY�6E   $��16(�5F      �� 5G      -	   5         ��Name$ txtTextSource��5G      $��
Текст��6-   $��2��6:   $��16(�5I      {�5H      �� $ enableButton��$ 	IsChecked�5I      5J      5K      5L      