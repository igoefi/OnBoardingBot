   M S B A M L   `   `   `  ����F  BTelegramBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:TelegramBot.Pages.AdminPanelTelegramBot.Pages.AdminPanel  5      +    %TelegramBot.Pages.AdminPanel.KeyWords   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:TelegramBot.Pages.AdminPanel     5        N� Title$  KeyWords��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � .+�5      �� $��Добавить��6   ���#F4EEE0$	��Top=�5      $��Center=�5      $��30(�5      � 5      $��	20,70,0,0q�5      .+�5      �� $
��Left=�5      $	��200��5       .+�5!      �� -   5        $��TxbKeyPhrase��5!       �� TextWrapping$
 Wrap=�5"      $��17(�5#       
  Phrase#��[  5$      �� 5%      -   5        $��	TxbAnswer��5%      $��0,10,0,0q�5&      $
 Wrap=�5'      $��17(�5(       
 Answer#��[ 5)      5*      5+      5,      �� 5.   
   -   5        
������ $	��100��50      $��30��51      $��Bottom=�52      $
��Left=�53      $��	10,0,0,20q�54      $��1��6$   ��55      �� 56       �� 
TargetType" ��6"   .R�57      � .+�58      ��  �� RadiusX$ 8��6$    �� RadiusY$ 5��59   ,   ���#4F45575;      �� 5<      $��Добавить��6$   $��Center=�5=   %   $��Center=�5>   %   ���#F4EEE05?   ,   5@      5A      5C      � 5E   
   $��1��6   .+�5F      �� $%��Изменить/Удалить��6   ���#F4EEE0$	��Top=�5H      $��Center=�5I      $��30(�5J      � 5L      $��	0,70,50,0q�5M      .+�5N      �� $��Right=�5O      $	��200��5P      .+�5Q      �� -   5        $��CmbBoxWords��5Q       	 Line2#��[ 5R      5S      �� 5T      -   5        $��TxbSelectedKeyPhrase��5T      $
 Wrap=�5U      $��17(�5V      #��[  5W      $��0,30,0,0q�5X      �� 5Y      -   5        $��TxbSelectedAnswer��5Y      $��0,10,0,0q�5Z      $
 Wrap=�5[      $��17(�5\      #��[ 5]      5^      5_      5`      �� 5b   
    �� Orientation$ 
Horizontal=�5c      $��Bottom=�5d      $��Right=�5e      $��1��5f      $��1��5g      .+�5h      �� -   5        
������ $	��100��5k      $��30��5l      $��	0,0,10,20q�5m      ��5n      �� 5o      " ��6&   .R�5p      � .+�5q      �� $ 8��6(   $ 5��5r   ,   ���#4F45575t      �� 5u      $��Удалить��6(   $��Center=�5v   %   $��Center=�5w   %   ���#F4EEE05x   ,   5y      5z      5|      �� 5~      -   5        
������ $	��100��5�      $��30��5�      $��	0,0,10,20q�5�      ��5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ 8��6(   $ 5��5�   ,   ���#4F45575�      �� 5�      $��Изменить��6(   $��Center=�5�   %   $��Center=�5�   %   ���#F4EEE05�   ,   5�      5�      5�      �� 5�      -	   5        
������ $	��100��5�      $��30��5�      $��	0,0,10,20q�5�      ��5�      �� 5�      " ��6&   .R�5�      � .+�5�      �� $ 8��6(   $ 5��5�   ,   ���#4F45575�      �� 5�      $��
Назад��6(   $��Center=�5�   %   $��Center=�5�   %   ���#F4EEE05�   ,   5�      5�      5�      5�      5�      5�      