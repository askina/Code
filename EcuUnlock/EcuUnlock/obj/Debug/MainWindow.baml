   M S B A M L   `   `   `  ����D  @EcuUnlock, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:EcuUnlock	EcuUnlock  5   	   H DStationConrol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:StationConrol;assembly=StationConrolStationConrol 5   	       EcuUnlock.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:EcuUnlock     5   	   Gcontrols2clr-namespace:StationConrol;assembly=StationConrol     5   	     � Title$  
MainWindow��5	   	   $	��900��6   $
��1250��6)   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
      StationConrol.UserControl1  $��0��6!   $��0��6.      ProductSerialNumber 6>   �� *%#DataContext.Op10ProductSerialNumber+ �� RelativeSource �� *FindAncestor+ �� AncestorType   EcuUnlock.MainWindow"     OperationResultColor 6�   �� *" DataContext.OperationResultColor+ �� *FindAncestor+"     OperationResultText 6p  �� *%#DataContext.Op10ProductSerialNumber+ �� *FindAncestor+"    5   
   $��0��6    $��1��6-    6=   �� *%#DataContext.Op10ProductSerialNumber+ �� *FindAncestor+"    5   
   -   5        $
��OP30��5   �   $��0��6    $��2��6-    6=   �� *" DataContext.OperationResultColor+ �� *FindAncestor+"  6�     5   
   $��1��6    $��0��6-   
 ��  �   
EcuMessage 6=   �� *%#DataContext.Op10ProductSerialNumber+ �� *FindAncestor+"  	   EcuSerialNumber1	 6�   �� *%#DataContext.Op10ProductSerialNumber+ �� *FindAncestor+"  6e    5   
   $��1��6    $��1��6-   5      5      