   M S B A M L   `   `   `  ���� C  ?Logoped1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Logoped1Logoped1      Logoped1.SecondPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     (localclr-namespace:Logoped1     -     N� Title$  
SecondPage��.���  � RowDefinitions �� $
��400* ��� $��50 �.+�&   System.Windows.Controls.DataGrid  -   $��DBLogo��   AutoGenerateColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    
FontFamily$ Comic Sans MS)�   
Foreground
 �   �1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *ID+  $ ФИО��$	 100 $ Comic Sans MS)�
 �   �	 �� *FIO+  $ Номер группы��$	 100 $ Comic Sans MS)�
 �   �	 �� *Class+  $% Дата поступления��$	 150 $ Comic Sans MS)�
 �   �	 �� *DateIncoming+  $% Социальная среда��$ * $ Comic Sans MS)�
 �   �	 �� *Zabolevanie+4  .System.Windows.Controls.DataGridTemplateColumn  
   CellTemplate
 �� .R��� $��EditBtn1��-   $ ��Редактировать��   MainWindowBtn#��[  $	��120��$��40��$��10(��� -   $��DelBtn1��$��Удалить��$��1��  EditBtn#��[ $��Right=�$��0 5 0 0q��� -   $��AddBtn1��$��Добавить��$��1��#��[ $
��Left=�$��0 5 0 0q�