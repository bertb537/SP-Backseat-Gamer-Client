   M S B A M L   `   `   `  ����N  JBackseatGamerClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BackseatGamerClientBackseatGamerClient  5      2    ,BackseatGamerClient.TrackingScreenInProgress   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:BackseatGamerClient     5        N� Title$  TrackingScreenInProgress��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   $	��Top=�6V   .+�5      �� -   5         ��Name$
 Logo��5         
HeaderLogo#��[  6&   �� 5      $��	 Tracking��6     HeaderTitle#��[ 6(   5      �� 5   
   -   5         ��Name$ Result_Label��5      $��1��6&     ResultLabelInProgress#��[ 63   $��In-Progress��6b   �� 5   
   $��2��6   $	��Top=�6   $	��220��66   $��10,10,10,20q�6F    �� Padding$ 
10,0,10,10q�6[   
�������$��2q�6�   ._�5      �� $ Vertical=�6   $	��Top=�60   .+�5      ��   Header1#��[ 6   $��Live Game Statistics��69   $
��Left=�6X   � 5      $��center=�6    � ColumnDefinitions 5      �� 5      $
��auto �6+   6:   �� 5      $��2* �6+   $	��100��66   $	��300��6E   6V   �� 5      $
��auto �6+   6:   �� 5      $��* �6+   $��30��65   $	��100��6C   6T    5!      �� 5"      6*   �� 5#      6*   �� 5$      6*   �� 5%      6*   �� 5&      6*   .+�5(      �� $��1��6   $��0��6)     	FormLabel#��[ 69   $��User: ��6\   �� 5)      $��1��6   $��1��6+     FormTextBox#��[ 6;   �� 5*      $��1��6   $��2��6)   #��[ 69   $��Eliminations: ��6\   �� 5+      $��1��6   $��3��6+   #��[ 6;   �� 5,      $��2��6   $��0��6)   #��[ 69   $��Battlenet ID: ��6\   �� 5-      $��2��6   $��1��6+   #��[ 6;   �� 5.      $��2��6   $��2��6)   #��[ 69   $��Deaths: ��6\   �� 5/      $��2��6   $��3��6+   #��[ 6;   �� 50      $��3��6   $��0��6)   #��[ 69   $��Map: ��6\   �� 51      $��3��6   $��1��6+   #��[ 6;   �� 52      $��4��6   $��0��6)   #��[ 69   $��Hero: ��6\   �� 53      $��4��6   $��1��6+   #��[ 6;   54      55      56      �� 57   
   -   5        $��3��57        
BackButton#��[ 69   $��Stop Tracking��6]   $��10,10,10,10q�6v   $
��auto��6�   $��Bottom=�6�   $
��Left=�6�   58      59      