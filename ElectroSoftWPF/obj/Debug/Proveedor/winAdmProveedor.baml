   M S B A M L   `   `   `  ����I  EElectroSoftWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ElectroSoftWPF.ProveedorElectroSoftWPF.Proveedor  5   	   .    (ElectroSoftWPF.Proveedor.winAdmProveedor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ElectroSoftWPF.Proveedor     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ winAdmProveedor��5   	   $	��500��6!   $	��900��6.    � WindowStyle$
 None=�6:    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ NoResize=�6r   $��2q�6�   ���#3F3E4E.��5      � ���#223046$��
0,10,-4,-4q�6     � ColumnDefinitions 5%   
   �� 5&      $
��700* �6   �� 5'      $
��100* �6   �� 5(      $
��100* �6   �� 5)      $
��100* �6   �� 5*      $
��100* �6    � RowDefinitions 5-   
   �� 5.      $	��15* �6   �� 5/      $	��50* �6   �� 50      $	��50* �6   �� 51      $	��50* �6   �� 52      $	��20* �6   .+�55   
   � $��34��6   $	��Top=�6   $��0��64   $��0��6D   $��5��6Q   ���#2174BA$��	0,-14,0,0q�6z   .+�56      �� -   5         ��Name$ btnClose��56      $	��Top=�6'   $��Right=�6?   $��35��6[   $��35��6f   
�������$��0q�6�   $y�Visible=�6�   ��6�   Z� ��6�   Z� .��57      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Close=�6*   
���  ��$��30��6H   $��30��6T   $��Center=�6_   58      59      �� 5:   
   
 �� Orientation$
 Vertical=�6   $��Center=�6,   $��5��6I   $��4��6Z   $	��333��6n   ���#302B2A$��
5,20,-5,-2q�6�   $��1��6�   .+�5;        $	 Car3Plus=�6&   $
��Left=�66   $��30��6Q   $��30��6\   
�������$��
272,21,0,0q�6{   �� 5<      
�������$��ADMINISTRAR PROVEEDORES��6+   $	��Top=�6J   $��
ExtraBlack"�6b   $��49��6z   $��79,-20,89,0q�6�   � 5=      $	��100��6   $
��Left=�6   $��Center=�6:   $��3��6U   $��38��6i   $��	0,-20,0,5q�6u   .+�5>      �� -   5         ��Name$ 	txtBuscar��5>      $	��150��6[   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Buscar��6h   $��25��6�   $��129,-5,-129,0q�6�   {�. 
����� �6�     5?      $	 Search=�6*   
�������$��Center=�6K   $��30��6i   $��30��6t    J� RenderTransformOrigin$ 1.667,0.583&�6�   5@      �� 5A      $��Nombres:��6   
�������$��20 0 0 0q�6;   �� 5B      -   5        $ 
txtNombres��5B      {�.  $ Nombres��6m   
����� �$��30��6�   $��120,-25,21,0q�6�   �� 5C      $��Primer Apellido:��6   
�������$��
20 10 10 0q�6B   �� 5D      -   5        $ txtPrimerApellido��5D      {�.  $ Primer Apellido��6y   
����� �$��30��6�   $��130,-25,21,0q�6�   �� 5E      $��Segundo Apellido:��6   
�������$��	20 10 0 0q�6C   �� 5F      -   5        $ txtSegundoApellido��5F      {�.  $ Segundo Apellido��6{   
����� �$��30��6�   $��150,-25,20,0q�6�   �� 5G      $��
Direccion:��6   
�������$��	20 10 0 0q�6<   �� 5H      -   5        $ txtDireccion��5H      {�.  $ 	Direccion��6o   
����� �$��30��6�   $��100,-25,21,0q�6�   �� 5I      $��
Teléfono:��6   
�������$��	20 10 0 0q�6;   �� 5J      -   5        $ txtTelefono��5J      {�.  $ Telefono��6m   
����� �$��30��6�   $��100,-25,73,0q�6�   5K      �� 5L   
   $��0��6   $��4��6%   $
 
Horizontal=�62   .+�5M      �� -	   5        $ btnInsertar��5M      $	��150��6*   $��Insertar��66   $��10q�6I   
����� ����#212F466�   �� 5N      -
   5        $ btnModificar��5N      $	��150��6+   $��	Modificar��67   $��10q�6K   
����� ����#212F466�   �� 5O      -   5        $ btnEliminar��5O      $	��150��6*   $��Eliminar��66   $��10q�6I   
����� ����#212F466�   5P      �� 5Q   
   $
 Vertical=�6   $��	5,150,0,0q�6-   $��Center=�6@   $��2��6]   $��1��6j   $��4��6z   $	��395��6�   $��2��6�   .+�5R      �� -   5        $ 
btnGuardar��5R      $��Guardar��6)   $��51,10,41,10q�6;   {�.  
����� ����#212F46$��36��6�   �� 5S      -   5        $ btnCancelar��5S      $��Cancelar��6*   $��51,10,41,10q�6=   {�. 
����� ����#212F466�   5U      &   System.Windows.Controls.DataGrid  5V   
   -   5          Name$ dgvDatos��5V         RowBackground �#212F46
�������   AlternatingRowBackground �#212F46
������ 
����� �$��1��6�   $��0��6�   $��3��6�   $��1��6�      
IsReadOnly .    CanUserAddRows .  $	��569��68  $	��Top=�6E     ColumnHeaderStyle 5W      �� 5X       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5Y      ��  �� Property � �� �� Value$ 10 10 10 10q�6/   �� 5Z       � ��
 ���� 63   �� 5[       � ��
 ��� �63   �� 5\       � ��$ 12(�61   �� 5]       � ��$
 Bold"�63   �� 5^       � ��$ Center=�6<   5_      5a      5b      5c      