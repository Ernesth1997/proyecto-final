   M S B A M L   `   `   `  ����I  EElectroSoftWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ElectroSoftWPF.CategoriaElectroSoftWPF.Categoria  5   	   /    )ElectroSoftWPF.Categoria.winAdmCategorias   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ElectroSoftWPF.Categoria     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � Title$ winAdmCategoria��5   
   $	��400��6"   $	��500��6/    � WindowStyle$
 None=�6;    � WindowStartupLocation$ CenterScreen=�6N    � 
ResizeMode$ NoResize=�6s   $��2q�6�   ���#3F3E4E.��5      � ���#223045$��0,-1,0,1q�6     � ColumnDefinitions 5   
   �� 5      $
��180* �6   �� 5      $	��90* �6   �� 5      $	��51* �6   �� 5      $	��40* �6   �� 5      $	��90* �6   �� 5      $	��90* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   �� 5!      $��2* �6   �� 5"      $��1* �6   �� 5#      $��1* �6   .+�5&   
   � ���#281E5D$��0��6$   $��0��64   $��1��6A   $��6��6R   $��0,0,-0.159,10q�6f   .+�5'      �� -   5         ��Name$ btnClose��5'      $	��Top=�6'   $��Right=�6?   $��35��6[   $��35��6f   
�������$��0q�6�   $y�Visible=�6�   ��6�   Z� ��6�   Z� .��5(      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Close=�6*   
�������
���  ��$��30��6[   $��30��6g   $��Center=�6r   5)      5*      �� 5,   
   $��1��6   $��1��6%   $��1��62   $��4��6C   $	��250��6W   $��	-10 0 0 0q�6c   .+�5-      �� 
�������$��ADMINISTRAR CATEGORIAS��6+   $��
ExtraBlack"�6K   $��	5,14,15,0q�6c     5.      $	 Category=�6&   $��Right=�67   $��24��6S   $��24��6^   
�������$��
0,-22,32,0q�6}   5/      �� 50   
   
 �� Orientation$
 Vertical=�6   $
��Left=�6,   $��0��6G   $��2��6W   $��6��6d   $��0,7,0,10q�6x   $��2��6�   $	��461��6�   .+�51      �� $��Nombre:��6   
�������6&   �� 5?      -   5         ��Name$ txtCategoria��5?      {�.  $	��Top=�6>   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre de Categoria��6V   $	��258��6�   $��25��6�   $��
30 -25 5 0q�6�   
������6�   �� 5A      $��Descripcion:��6   
�������$��0 16 0 0q�6B   �� 5B      -   5        $ txtDescripcion��5B      {�.  $	��Top=�6@   $ Descripcion��6X   $	��258��6�   $��25��6�   $��
30 -25 5 0q�6�   
������6�   5C      �� 5D   
   $
 
Horizontal=�6   $��Center=�6/   $��0��6L   $��4��6\   $��6��6i   .+�5E      �� -   5        $ 
btnGuardar��5E      $��Guardar��6)   $��5q�6;   {�.  
����� ����#281E5D6�   �� 5F      -   5        $ btnCancelar��5F      $��Cancelar��6*   $��5q�6=   {�. 
����� ����#281E5D6�   �� 5G      -   5        $ btnInsertar��5G      $��Insertar��6*   $��5q�6=   
����� ����#281E5D6u   �� 5H      -   5        $ btnModificar��5H      $��	Modificar��6+   $��5q�6?   
����� ����#281E5D6x   �� 5I      -	   5        $ btnEliminar��5I      $��Eliminar��6*   $��5q�6=   
����� ����#281E5D6u   5J      &   System.Windows.Controls.DataGrid  5K   
   -
   5          Name$ dgvDatos��5K      $��0q�6%   
������ $��Normal$�6R   
�������
����� �$	��480��6�   $��0��6�   $��5��6�   $��6��6�   $��6��6�      
IsReadOnly .    CanUserAddRows .     ColumnHeaderStyle 5L      �� 5M       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5N      ��  �� Property � �� �� Value$ 10 10 10 10q�6/   �� 5O       � ��
 ���� 63   �� 5P       � ��
 �����63   �� 5Q       � ��$ 12(�61   �� 5R       � ��$
 Bold"�63   �� 5S       � ��$ Center=�6<   5T      5V      5W      5X      