   M S B A M L   `   `   `  ����C  ?Logoped1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Logoped1Logoped1  5          Logoped1.SecondPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Logoped1     5      -   5          N� Title$  
SecondPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��400* �6   �� 5      $��50 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DBLogo��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6K      
FontFamily$ Comic Sans MS)�6W      
Foreground
 �   �1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *ID+6r     5      $ ФИО��6%   $	 100 6J   $ Comic Sans MS)�6V   
 �   �	 62   �� *FIO+6q     5      $ Номер группы��6%   $	 100 6U   $ Comic Sans MS)�6a   
 �   �	 6;   �� *Class+6|     5      $% Дата поступления��6%   $	 150 6`   $ Comic Sans MS)�6l   
 �   �	 6?   �� *DateIncoming+6�     5      $% Социальная среда��6%   $ * 6_   $ Comic Sans MS)�6i   
 �   �	 6?   �� *Zabolevanie+6�   4  .System.Windows.Controls.DataGridTemplateColumn  5      
   CellTemplate
 5      �� 5      .R�5      �� $��EditBtn1��6%   -   5        $ ��Редактировать��5   5      MainWindowBtn#��[  6M   $	��120��6t   $��40��6�   $��10(�6�   6�   5      5      5      �� 5    
   -   5        $��DelBtn1��5    #   $��Удалить��6   $��1��62     EditBtn#��[ 6?   $��Right=�6v   $��0 5 0 0q�6�   �� 5!   
   -   5        $��AddBtn1��5!   $   $��Добавить��6   $��1��63   #��[ 6@   $
��Left=�6w   $��0 5 0 0q�6�   5"      5#      