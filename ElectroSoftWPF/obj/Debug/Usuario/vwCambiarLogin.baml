   M S B A M L   `   `   `  ����I  EElectroSoftWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ElectroSoftWPF.UsuarioElectroSoftWPF.Usuario  5   	   +    %ElectroSoftWPF.Usuario.vwCambiarLogin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ElectroSoftWPF.Usuario     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5	   	   $��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ winAdmProveedor��5   	   $	��750��6!   $	��800��6.    � WindowStyle$
 None=�6:    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ NoResize=�6r   $��2q�6�   ���#3F3E4E.��5      � ���#082740$��
0,10,-4,-4q�6     � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6    � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��45* �6   �� 5      $
��106* �6   �� 5       $
��106* �6   �� 5!      $
��106* �6   .+�5#   
   �� $��0��6   $��0��6%   $��5��62   .+�5$      � $��36��6   $	��Top=�6   ���#302B2A 5%      �� 5&      $
��149* �6'   �� 5'      $
��151* �6'   .+�5)      �� -   5         ��Name$ btnClose��5)      $	��Top=�6+   $��Right=�6C   $��35��6_   $��35��6j   
�������$��0q�6�   $y�Visible=�6�   $��1��6�   ��6�   Z� ��6�   Z� .��5*      '  !MaterialDesignThemes.Wpf.PackIcon  
���  ��	   Kind$	 Close=�6?   
�������$��30��6_   $��30��6k   $��Center=�6v   5+      5,      5-      �� 5.   
   $��1��6   $��1��6$   $��3��61   
��� ���$��CAMBIAR PASSWORD��6Y   $��Center=�6q   $��Center=�6�   $��156,25,132,26q�6�   $��
ExtraBlack"�6�   $��16��6�   $	��192��6�     5/   
   $	 PasswordReset=�6#   $��2��68   $��1��6H   
��� ���$��Right=�6i   $��30��6�   $��30��6�   
 J� RenderTransformOrigin$
 1.667,0.583&�6�   $��
0,16,129,0q�6�   $��2��6�   �� 50   
   -   5        $��stpDatos��50       �� Orientation$ 
Horizontal=�6%   $��Center=�6>   $��0��6[   $��2��6k   $��1��6x   $��5��6�   $
��10,0q�6�   $	��780��6�   .+�51      �� $��Nombre Usuario:��6   
�������$��	0,14,0,24q�6A   �� 52      -   5         ��Name$ txtNombreUsuario��52      $	��124��6f   {�.  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nombre Usuario��6�   
����� �$��30��6�   $��
20,8,10,29q�6�   �� 53      $��Password Actual:��6   $��Center=�60   
�������$��	0,15,0,28q�6^   G� 54      -   5         G�Name$ txtPasswordA��54      $	��123��61   $ Password Actual��6>   
����� �$��30��6�   $��
20,8,10,29q�6�   �� 55      $��Password Nuevo:��6   
�������$��	0,11,0,26q�6A   G� 56      -   5        $ txtPasswordN��56      $	��150��61   $ Password Nuevo��6=   
����� �$��30��6�   $��20 -20 10 0q�6�   57      �� 58   
   $ 
Horizontal=�6   $��
20,57,37,0q�6/   $��Center=�6C   $��2��6`   $��0��6m   $��5��6}   $	��583��6�   $��2��6�   .+�59      �� -   5        $ txtModificar��59      
��� ���$	��150��6Z   $��	Modificar��6f   $��125 -20 20 0q�6z   
����� ����#302B2A6�   �� 5:      -   5        $ btnCancelar��5:      
��� ���$	��150��6X   $��Cancelar��6d   $��	0 -20 0 0q�6w   
����� ����#302B2A6�   5;      &   System.Windows.Controls.DataGrid  5<   
   -	   5          Name$ DgvDatos��5<         RowBackground �#212F46
�������   AlternatingRowBackground �#212F46
������ 
����� �$��4��6�   $��0��6�   $��5��6�   $��4��6�   $��5,5,5,0q�6�      
IsReadOnly .    CanUserAddRows .     ColumnHeaderStyle 5=      �� 5>       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5?      ��  �� Property � �� �� Value$ 10 10 10 10q�6/   �� 5@       � ��
 ���� 63   �� 5A       � ��
 � ���63   �� 5B       � ��$ 12(�61   �� 5C       � ��$
 Bold"�63   �� 5D       � ��$ Center=�6<   5E      5G      5H      5I      