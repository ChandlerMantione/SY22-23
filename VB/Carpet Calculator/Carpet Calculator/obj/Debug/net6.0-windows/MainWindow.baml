   M S B A M L   `   `   `  ����L  HCarpet Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Carpet_CalculatorCarpet_Calculator  5   	   "    Carpet_Calculator.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Carpet_Calculator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ LengthTextbox��5
      $
��Left=�6)   $��222,173,0,0q�6D    �� TextWrapping$
 Wrap=�6Y   $��TextBox��6m   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ WidthTextbox��5      $
��Left=�6(   $��384,173,0,0q�6C   $
 Wrap=�6X   $��TextBox��6l   $	��Top=�6{   $	��120��6�   �� 5   
   -   5         ��Name$ LengthSlider��5      $
��Left=�6'   $��222,196,0,0q�6B   $	��Top=�6W   $	��120��6o   6{   �� 5   
   -   5        $ WidthSlider��5      $
��Left=�6&   $��384,199,0,0q�6A   $	��Top=�6V   $	��120��6n   6z   �� 5   
   $��Length��6   $
��Left=�6!   $��175,169,0,0q�6<   $	��Top=�6Q   �� 5   
   $��Width��6   $
��Left=�6    $��342,170,0,0q�6;   $	��Top=�6P   �� 5   
   $
��Left=�6   $	��100��6+   $��
238,45,0,0q�68   $	��Top=�6L   $	��100��6d   $��/RedCarpet.jpg��6p    �� StretchDirection$ UpOnly=�6�   �� 5   
   -   5         ��Name$ CarpetCombobox��5      $
��Left=�6+   $��	82,79,0,0q�6F   $	��Top=�6Y   $	��120��6q   .@�5      �� 
���  ��$	��Red��6,   �� 5      
��� � �$��Green��6.   �� 5      
����  �$
��Blue��6-   5      �� 5   
   -   5         ��Name$ ClearButton��5      $��Clear��6&   $
��Left=�66   $��282,278,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5        $ CloseButton��5      $��Close��6&   $
��Left=�66   $��411,278,0,0q�6Q   $	��Top=�6f   �� 5   
   -   5         ��Name$ SumLable��5      $��Label��6"   $
��Left=�62   $��342,219,0,0q�6M   $	��Top=�6b   �� 5   
   $��Total:��6   $
��Left=�6!   $��307,219,0,0q�6<   $	��Top=�6Q   �� 5   
   $
��Left=�6   $	��100��6+   $��
363,45,0,0q�68   $	��Top=�6L   $	��100��6d   $��/GreenCarpet.jpeg��6p   $ UpOnly=�6�   �� 5   
   $
��Left=�6   $	��100��6+   $��
492,45,0,0q�68   $	��Top=�6L   $	��100��6d   $��/BlueCarpet.jpg��6p   �� 5   
   -	   5        $ 
CalcButton��5      $��	Calculate��6%   $
��Left=�69   $��238,222,0,0q�6T   $	��Top=�6i   �� 5   
   $��Red: $4 per Sq. Ft.��6   $
��Left=�6.   $��230,142,0,0q�6I   $	��Top=�6^   �� 5   
   $��Green: $5 per Sq. Ft.��6   $
��Left=�60   $��361,144,0,0q�6K   $	��Top=�6`   �� 5   
   $��Blue: $6 per Sq. Ft.��6   $
��Left=�6/   $��488,142,0,0q�6J   $	��Top=�6_   5!      5"      