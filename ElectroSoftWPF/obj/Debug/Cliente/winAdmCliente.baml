   M S B A M L   `   `   `  ����I  EElectroSoftWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ElectroSoftWPF.ClienteElectroSoftWPF.Cliente  5   	   *    $ElectroSoftWPF.Cliente.winAdmCliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ElectroSoftWPF.Cliente     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � Title$ winAdmCliente��5   
   $	��400��6    $	��620��6-    � WindowStyle$
 None=�69    � WindowStartupLocation$ CenterScreen=�6L    � 
ResizeMode$ NoResize=�6q   $��2q�6�   ���#3F3E4E.��5      � ���#082740$��
0,10,-4,-4q�6     � ColumnDefinitions 5   
   �� 5      $
��180* �6   �� 5      $	��90* �6   �� 5      $	��51* �6   �� 5      $	��40* �6   �� 5      $	��90* �6   �� 5      $	��90* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   �� 5!      $��1* �6   �� 5"      $��2* �6   �� 5#      $��1* �6   �� 5$      $��1* �6   .+�5(   
   � $��34��6   $	��Top=�6   $��0��64   $��0��6D   $��6��6Q   ���#2174BA$��	0,-14,0,0q�6z   .+�5)      �� -   5         ��Name$ btnClose��5)      $	��Top=�6'   $��Right=�6?   $��35��6[   $��35��6f   
�������$��0q�6�   $y�Visible=�6�   ��6�   Z� ��6�   Z� .��5*      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Close=�6*   
���  ��$��30��6H   $��30��6T   $��Center=�6_   5+      5,        5-   
   $	 	UserBadge=�6"   $��3��63   $��1��6C   $��Right=�6P   $��30��6l   $��30��6w   
�������6�   �� 5.   
   
�������$��1��6'   $��4��65   $��REGISTRO DE CLIENTES��6I   $��Center=�6e   $��
ExtraBlack"�6�   $��173,14,6,13q�6�   �� 5/   
   $	��Top=�6   
 �� Orientation$
 
Horizontal=�60   $��0��6J   $��2��6Z   $��5��6g   .+�50      �� $
��Nit:��6   
�������$��80��69   $��25��6E   $��2q�6Q   �� 51      -   5         ��Name$ txtNit��51      $	��100��6&   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ NIT/C.I.��64   $��25��6`   $��5q�6l   {�.  $
��Bold"�6�   ���#2174BA6�   �� 52      $��RazonSocial:��6   
�������6+   �� 53      -   5        $ txtRazonSocial��53      $	��100��6/   $ Nombre/Apellido��6<   $��25��6n   $
��Bold"�6�   $��5q�6�   {�.  ���#2174BA6  54      �� 55   
   
������ $��4��60   $��4��6A   $��2��6N   $��4��6b   $��
20 -10 0 0q�6s   .+�56      �� -   5        $ 
btnGuardar��56      $��Guardar��6)   $��5q�6;   {�.  ���#082740���#2174BA6�   �� 57      -   5        $ btnCancelar��57      $��Cancelar��6*   $��5q�6=   {�. ���#082740���#2174BA6�   �� 58      -   5        $ btnInsertar��58      $��Insertar��6*   $��5q�6=   ���#082740���#2174BA6x   �� 59      -   5        $ btnModificar��59      $��	Modificar��6+   $��5q�6?   ���#082740���#2174BA6{   �� 5:      -	   5        $ btnEliminar��5:      $��Eliminar��6*   $��5q�6=   ���#082740���#2174BA6x   5<      � 5=   
   $	��100��5>      $��3��6   $��2��6'   $��Center=�64   $��Center=�6Q   $��3��6l   $��38��6�   $��34.5,0,85,5q�6�   .+�5?        $	 Search=�6&   
�������$��Center=�6G   $��30��6e   $��30��6p    J� RenderTransformOrigin$ 1.667,0.583&�6|   �� 5@      -
   5        $ 	txtBuscar��5@      $	��100��6)   $ Buscar��66   $��25��6_   $��83,6,-103,13q�6�   {�. ���#2174BA6�   5A      �� 5B   
   $��0��6   $��Center=�6'   $��Center=�6D   $��3��6`   $��7��6t   .+�5C      �� -   5        $��BtnSelecCliente��5C      .��6K   Seleccionar Datos Cliente6f   5D      &   System.Windows.Controls.DataGrid  5E   
   -   5          Name$ dgvDatos��5E      
������ 
����������#2174BA$��0��6h   $��3��6x   $��4��6�   $��4��6�      
IsReadOnly .    CanUserAddRows .     ColumnHeaderStyle 5F      �� 5G       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5H      ��  �� Property � �� �� Value$ 10 10 10 10q�6/   �� 5I       � ��
 ���� 63   �� 5J       � �� �#2174BA63   �� 5K       � ��$ 12(�61   �� 5L       � ��$
 Bold"�63   �� 5M       � ��$ Center=�6<   5N      5P      5Q      5S      