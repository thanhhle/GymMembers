   M S B A M L   `   `   `  ����E  AGymMembers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GymMembers.ViewModelGymMembers.ViewModel  5   
   'clr-namespace:GymMembers
GymMembers  5   
   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5	   
        GymMembers.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   
   @d2http://schemas.microsoft.com/expression/blend/2008     5   
   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   
   1vm"clr-namespace:GymMembers.ViewModel     5   
   *localclr-namespace:GymMembers     5   
   ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5	   
   -   5        $��
mainWindow��5   
     � Title$  Gym Memberships��5   
   $	��350��6"   $	��525��6/    � DataContext 5   
   ��    Locator �� Source# [   �� Path$
 Main�.��5      � ���	#FFECEAEA.+�5   
   �� -   5         ��Name$ 	AddButton��5      $	��Add��6$   $��1��62   $��1��6@   $
��Left=�6p   $	��Top=�6�   $��75��6�   $��0,50,0,0q�6�   ��6Q   �� *
AddCommand+6�   �� 5   
   -   5        $ 
ExitButton��5      $
��Exit��6%   $��1��64   $��1��6B   $
��Left=�6�   $��Bottom=�6�   $��75��6�   $��0,0,0,50q�6�   ��6S   �� *ExitCommand+��6s   ��  �� ElementName$ 
mainWindow��6�   �� 5   
   -   5         ��Name$ ListBox��5      $��1��6n   $��0��6|   $��Center=�6�   $��Center=�6�   $	��220��6�   $	��322��6�   ��6#   �� *
MemberList+ �� SelectedItem 6F   �� *SelectedMember+.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5      	   	EventName$	 MouseUp��6!   .  (System.Windows.Interactivity.TriggerBase
   Actions.
 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *ChangeCommand+5      5      �� 5   
   -   5         ��Name$ label��5      $��
Customers:��6   $��0��64   $��0��6B   $
��Left=�6S   $��Bottom=�6n    � ColumnDefinitions 5   
   �� 5      $	��380 �6   �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5       $	��250 �6   �� 5!      $��* �6   5#      5$      