   M S B A M L   `   `   `  ����F  BGrpcServeur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:GrpcServeurGrpcServeur  5   	   %    GrpcServeur.ServerConfiguration   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:GrpcServeur     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ gRPC Server Configuration��5
   	   $	��180��6+   $	��300��68    � WindowStartupLocation$ CenterScreen=�6D   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   6.   �� 5      $��1* �6   6,   �� 5      $
��0.1* �6   6.   �� 5      $��2* �6   6,   �� 5      $
��0.1* �6   6.    � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��* �6   6)   �� 5      $
��0.1* �6   6,   �� 5      $��* �6   6)   �� 5      $
��0.1* �6   6,   �� 5      $��* �6   6)   �� 5      $
��0.1* �6   6,   .+�5   
   �� -   5        $��ServerStatus��5      $��5��6$   $��18(�68   $��Center=�6F   $��Center=�6j   
�������6�   �� 5   
   $��Address:��6   $��1��6$   $��1��64   $��Center=�6A   6^   �� 5   
   -   5        $��
AddressTxt��5      $��1��6$   $��3��61   $��25��6A   6O   �� 5   
   $��Port:��6   $��1��6!   $��3��61   $��Center=�6>   6[   �� 5    
   -   5        $��PortTxt��5       $��3��6!   $��3��6.   $��25��6>   $	��100��6J   $
��Left=�6V   6s   �� 5"   
   -   5        $��1��5"   '   $��5��67   $��25��6D   .��6P   Stop6V   �� 5#   
   -   5        $��3��5#      $��5��6!   $��25��6.   $	��100��6:   .��6]   Start6d   5$      5%      