   M S B A M L   `   `   `  ����?  ;tour, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:tour.Pages
tour.Pages  5      #    tour.Pages.ClientChangingPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:tour.Pages     5      -   5          N� Title$  ClientChangingPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��19* �6   �� 5      $	��75* �6   �� 5      $	��25* �6   �� 5      $	��84* �6   �� 5      $	��83* �6   �� 5      $	��43* �6   �� 5      $
��171* �6    � RowDefinitions 5   
   �� 5      $	��32* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��42* �6   �� 5      $	��41* �6   �� 5      $	��42* �6   �� 5      $	��30* �6   �� 5      $	��17* �6   �� 5       $	��38* �6   �� 5!      $	��36* �6   �� 5"      $	��31* �6   �� 5#      $	��23* �6   .+�5%   
   �� $��1��6   $��Right=�6!   $��69��6=   $��1��6H   
First name6d   �� 5&   
   $��2��6   $��Right=�6!   $��84��6=   $��2��6H   Second name6i   �� 5'   
   $��4��6   $��Right=�6!   $��47��6=   $��1��6H   E-mail6`   �� 5(   
   $��3��6   $��Right=�6!   $��66��6=   $��1��6H   	Last name6d   �� 5)   
   $��5��6   $��Right=�6!   $��82��6=   $��2��6H   Date of birth6k   �� 5*   
   $��6��6   $��Right=�6!   $��41��6=   $��1��6H   Phone6_   �� 5+   
   $��8��6   $��Right=�6!   $��53��6=   $��1��6H   Gender6`   �� 5.   
   -   5        $��fname��5.   /   $��1��6   $��3��6   $��3��6<   $
��Auto��6P   $��30,11q�6^   $
��Auto��6m   6|   �� 5/   
   -   5        $��sname��5/   /   $��2��6   $��3��6   $��3��6=   $
��Auto��6Q   $��30,11q�6_   $
��Auto��6n   6~   �� 50   
   -   5        $��lname��50   /   $��3��6   $��3��6   $��3��6<   $
��Auto��6P   $��30,11q�6^   $
��Auto��6m   6}   �� 51   
   -   5        $��email��51   /   $��4��6   $��3��6   $��3��6=   $
��Auto��6Q   $��30,11q�6_   $
��Auto��6n   6}   (  "System.Windows.Controls.DatePicker  52   
   -   5        $��	birthdate��52   2   $��5��6   $��3��6"   $��3��6C   6Y   �� 53   
   -   5        $��phone��53   /   $��6��6   $��3��6   $��3��6<   $
��Auto��6P   $��30,10,30,11q�6^   $
��Auto��6s   6�   �� 54   
   -   5        $��gender��54   0   $��8��6   $��3��6    $��3��6>   $��	30,6,30,1q�6R   $
��Auto��6e   $
��Auto��6s   6�   �� 55   
   $��7��6   $��1��6!   Номер паспорта6B   �� 56   
   -	   5        $��passnum��56      $��7��6!   $��3��6.   $��2��6>   6T   �� 58   
   -
   5        $
��save��58   0    	  basic#��[  6   $��11��6<   $��1��6J   $��2��6[   .��6�   '%Сохранить изменения6�   �� 59   
   -   5        $
��exit��59   0   #��[  6   $��12��6<   $��1��6J   $��2��6n   .��6�   Exit6�   5;      5<      