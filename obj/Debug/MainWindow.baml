   M S B A M L   `   `   `  ����J  Fcolor converter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:color_convertercolor_converter  5   	        color_converter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:color_converter     5   	   -   5          �Name$  hatter��5	   	    � 
ResizeMode$ NoResize=�5   	    � Title$ 
MainWindow��5
   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   �� $
��Red:��6   $
��Left=�6   $��	25,50,0,0q�6:   $	��Top=�6M    J� RenderTransformOrigin$ 0.196,-1.366&�6e   $��25(�6�   �� 5   
   $��Green:��6   $
��Left=�6!   $��
25,100,0,0q�6<   $	��Top=�6P   $ -0.897,-2.58&�6h   $��25(�6�   �� 5   
   $��Blue:��6   $
��Left=�6    $��
25,150,0,0q�6;   $	��Top=�6O   $ -0.837,-2.354&�6g   $��25(�6�   �� 5   
   -   5         ��Name$
 redt��5      $
��Left=�6    $��
105,55,0,0q�6;    �� TextWrapping$
 Wrap=�6O   $	��255��6c   $	��Top=�6n   $	��120��6�   $��25(�6�   6�   �� 5   
   -   5        $ greent��5      $
��Left=�6"   $��105,105,0,0q�6=   $
 Wrap=�6R   $	��255��6f   $	��Top=�6q   $	��120��6�   $��25(�6�   6�   �� 5   
   -   5        $ bluet��5      $
��Left=�6!   $��105,155,0,0q�6<   $	��255��6R   $	��Top=�6]   $	��120��6u   $��25(�6�   6�   �� 5   
   -   5         ��Name$
 reds��5       � Maximum$	 255Q�6    �� TickFrequency$ 1Q�6-   	 � SmallChange$	 1Q�6?   $��
250,65,0,0q�6O   $
��Left=�6c   $��25��6   $	��Top=�6�   $	��200��6�   
 � Value$	
 255Q�6�   6�   �� 5   
   -   5        $ greens��5      $
��Left=�6!   $��25��6<   $��250,115,0,0q�6H   $	��Top=�6]   $	��200��6u   $	 255Q�6�   $	
 255Q�6�   6�   �� 5   
   -   5        $ blues��5      $
��Left=�6    $��25��6;   $��250,165,0,0q�6G   $	��Top=�6\   $	��200��6t   $	 255Q�6�   $	
 255Q�6�   6�   �� 5   
   $
��Hex:��6   $
��Left=�6   $��
575,50,0,0q�6:   $	��Top=�6N   $ 0.523,-0.473&�6f   $��25(�6�   �� 5   
   -   5        $	 hex��5      $
��Left=�6   $��25(�6:   $��575,100,0,0q�6H   $
 Wrap=�6]   $��#FFFFFF��6q   $	��Top=�6�   $	��120��6�   6�   5      5      