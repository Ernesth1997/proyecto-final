   M S B A M L   `   `   `  ����I  EElectroSoftWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ElectroSoftWPF.ProductoElectroSoftWPF.Producto  5   	   .    (ElectroSoftWPF.Producto.winListaProducto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ElectroSoftWPF.Producto     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ winAdmProductos��5   	   $	��550��6!   $	��810��6.    � WindowStyle$
 None=�6:    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ NoResize=�6r   $��2q�6�   ���#3F3E4E.��5      � ���#082754$��0,0,-4,0q�6     � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6    � RowDefinitions 5   
   �� 5      $	��25* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5       $	��50* �6   .+�5"   
   �� $��0��6   $��0��6%   $��3��62   .+�5#      � $��51��6   $	��Top=�6   ���#0074D0.+�5$      �� -   5         ��Name$ btnClose��5$      $	��Top=�6+   $
��Left=�6C   $��35��6^   $��35��6i   
�������$��0q�6�   $y�Visible=�6�   $��	775 0 0 0q�6�   ��6�   Z� ��6�   Z� .��5%      '  !MaterialDesignThemes.Wpf.PackIcon  
���  ��	   Kind$	 Close=�6?   
�������$��35��6_   $��30��6k   $��Center=�6v   5&      5'      5(      &   System.Windows.Controls.DataGrid  5)   
   -   5        
  Name$
 dgvDatos��5)         RowBackground �#212F46
�������   AlternatingRowBackground �#212F46
������ 
����� �$��1��6�   $��0��6�   $��3��6�   $��3��6�      
IsReadOnly .    CanUserAddRows .  $��12(�6   � ContextMenu 5*      �� 5+      .@�5,      m� -   5         m�Name$ miSelectProducto��5,      $5��/Selecciona datos del producto que quiera vender��69   6r   5-         ColumnHeaderStyle 5/      �� 50       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�51      ��  �� Property � �� �� Value$ 10 10 10 10q�6/   �� 52       � ��
 ���� 63   �� 53       � ��
 �����63   �� 54       � ��$ 13(�61   �� 55       � ��$
 Bold"�63   �� 56       � ��$ Center=�6<   57      59      �� 5:   
   $��1��6   $��Center=�6&   $��4��6A   .+�5;      �� -   5        $��BtnSelecionarProducto��5;      .��6X   Seleccionar un Producto6q   5<      5?      5@      