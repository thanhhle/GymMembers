   M S B A M L   `   `   `  ����E  AGymMembers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:GymMembers.ViewGymMembers.View  5   
   "    GymMembers.View.ChangeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   
   @d2http://schemas.microsoft.com/expression/blend/2008     5   
   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   
   /localclr-namespace:GymMembers.View     5   
   -   5        $��changeWindow��5   
     � Title$  Change Membership��5
   
   $	��237��6$   $	��300��61    � DataContext 5	   
   ��    Locator �� Source# [   �� Path$ Change�.��5      � ���	#FFECEAEA � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��30 �6   .+�5   
   �� -   5         ��Name$ 
FNameLabel��5      $��First Name:��6$   $��Center=�6:   $��Center=�6W   $��1��6r   $��0��6   �� 5   
   -   5        $ 
LNameLabel��5      $��
Last Name:��6$   $��Center=�69   $��Center=�6V   $��2��6q   $��0��6~   �� 5   
   -   5        $ 
EmailLabel��5      $��E-mail:��6$   $��Center=�66   $��Center=�6S   $��3��6n   $��0��6{   �� 5   
   -   5         ��Name$ FNameTB��5      $��Center=�6#   $��23��6@    �� TextWrapping$
 Wrap=�6L   $��Center=�6`   $	��120��6�   $��1��6�   $��1��6�   ��6{   �� *SelectedMember.FirstName+6�   �� 5   
   -   5        $ LNameTB��5      $��Center=�6#   $��23��6@   $
 Wrap=�6L   $��Center=�6`   $	��120��6�   $��2��6�   $��1��6�   ��6{   �� *SelectedMember.LastName+6�   �� 5   
   -   5        $ EmailTB��5      $��Center=�6#   $��23��6@   $
 Wrap=�6L   $��Center=�6`   $	��120��6�   $��3��6�   $��1��6�   ��6{   �� *SelectedMember.Email+6�   �� 5   
   -   5        	 ��Name$	 UpdateButton��5      $��Update��6'   $��Center=�68   $	��Top=�6U   $��75��6�   $��4��6�   $��0��6�   ��6m   �� *UpdateCommand+��6�   �� 
 �� ElementName$
 changeWindow��6�   �� 5    
   -	   5        $	 DeleteButton��5       $��Delete��6'   $��Center=�68   $	��Top=�6U   $��75��6�   $��4��6�   $��1��6�   ��6m   �� *DeleteCommand+��6�   �� $
 changeWindow��6�   5!      5"      