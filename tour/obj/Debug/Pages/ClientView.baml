   M S B A M L   `   `   `  ����?  ;tour, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:tour.Pages
tour.Pages  5          tour.Pages.ClientView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:tour.Pages     5      -   5          N� Title$  
ClientView��5	      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
clientview��5      $	��300��6%      AreRowDetailsFrozen .    SelectionMode$ Single=�6|      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%      CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *
LastName+6k     5      $ Имя��6%    .   62   �� *	FirstName+6i     5      $ Отчество��6%    67   �� *
SecondName+6Y     5      $ Пол��6%    62   �� *Gender+6P     5      $ Телефон��6%    66   �� *Phone+6S     5      $ Пасспорт��6%    67   �� *PassportNum+6Z     5      $ E-mail��6%    65   �� *Email+6R   5      �� 5   
   -   5        $
��back��5   G   $��Bottom=�6   $
��Left=�6,   .��6g   
Назад6n   �� 5   
   -   5        $��change��5   I   $��Bottom=�6   $��Center=�6,   .��6l   Изменить6v   5      5      