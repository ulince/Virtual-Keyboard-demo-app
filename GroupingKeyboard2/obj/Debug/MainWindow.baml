   M S B A M L   `   `   `  ����@  <WpfKb, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null>+clr-namespace:WpfKb.Controls;assembly=WpfKbWpfKb.Controls  5   	    GroupingKeyboard2"   GroupingKeyboard2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   =WpfKb+clr-namespace:WpfKb.Controls;assembly=WpfKb     5   	     � Title$  
MainWindow��5   	   $��896.045��6   $��1102.612��6-    � WindowState$ 	Maximized=�5   	    � 	Resources 5         InitialMatrixTransform u� Matrix � OffsetX � OffsetY��%Z   &	        u� 5   
    5      � 5      $	 200Q�6   $	 200Q�6'   5      5      .��5      �� -   5         ��Name$ canvas��5      
������ $��0,0,-354,-1069q�67   .+�5   
   �� -   5         ��Name$ 	groupBox1��5      $�� ��5       �� Left$
 -118��5      
	 �� Top$
	 -149��5      $	��380��5      $	��417��5      
 J� IsManipulationEnabled
 . #z�[  5       K� ZIndex$ 1��5       
������ ��5!      �� 5"       �� ImageSource$ Resources/postIt.png��6    j� Stretch$
 None=�6@   .��5$      �� -   5        $��txtBox1��5$      $
��Left=�5%      $	��288��5&       �� TextWrapping$
 Wrap=�5'      $	��Top=�5(      $	��324��5)      
������ $��	28,10,0,0q�5+       J� RenderTransformOrigin$ 
0.549,0.16&�6)   
������ $��24(�6�   5,      �� 5-   
   -   5        $ 	groupBox2��5-      $�� ��5.      $	 386��5/      $
	 -121��50      $	��391��51      $	��439��52      
 . #z�[  54      
������ ��57      �� 58      $ Resources/postIt.png��6   $
 None=�6@   .��5:      �� -   5        $��txtBox2��5:      $
��Left=�5;      $	��291��5<      $
 Wrap=�5=      $	��Top=�5>      $	��323��5?      
������ $��	40,10,0,0q�5A      
������ 6e   5B      0   *WpfKb.Controls.FloatingTouchScreenKeyboard  5C   
   -   5          Name$ Keyboard��5D      ��. $	��900��5F      $	��400��5G      $��Center=�5I         AreAnimationsEnabled .  � PlacementTarget 5H      ��  �� ElementName$ 
TestWindow��5J      5N      5O      