   M S B A M L   `   `   `  ����?  ;tour, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:tour.Pages
tour.Pages  5          tour.Pages.ChangeTourPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:tour.Pages     5      -   5          N� Title$  ChangeTourPage��5	      .��5      � .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  �� Padding$ 10,10,35,10q�6   Название тура6A   �� 5      -   5        $��tourname��5      6,   5      �� 5      $ 
Horizontal=�6   .+�5      �� $ 10,10,45,10q�6   Начало тура6?   (  "System.Windows.Controls.DatePicker  5      -   5        $��	beginning��5      60   5      �� 5      $ 
Horizontal=�6   .+�5      �� $ 10,10,50,10q�6   Конец тура6>     5      -   5        $��ending��5      6-   5      �� 5      $ 
Horizontal=�6   .+�5      �� $ 10,10,50,10q�6   Стоимость6=   �� 5      -   5        $
��cost��5      6(   5      �� 5      $ 
Horizontal=�6   .+�5      �� $ 10,10,75,10q�6   Рейтинг6;   �� 5      -   5        $
��rate��5       � Maximum$ 5Q�6%    � Minimum$ 2Q�61   $	��150��6=   6K   5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $ 10,10,10,10q�6   !Место назначения6D   �� 5#      -   5        $
��dest��5#      6)   5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $ 10,10,68,10q�6   Описание6<   �� 5'      -   5        $��descr��5'      $	��100��6'   66   5(      5*      �� 5+   
   -	   5        $
��save��5+      $��Bottom=�6   $��90��6K    	  basic#��[  6V   .��6u   Сохранить6�   �� 5,   
   -
   5        $
��back��5,      $��Bottom=�6   $
��Left=�68   $��90��6g   #��[  6r   .��6�   
Назад6�   5.      5/      