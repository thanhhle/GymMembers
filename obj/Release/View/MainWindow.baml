   M S B A M L   `   `   `  ���� E  AGymMembers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GymMembers.ViewModelGymMembers.ViewModel  'clr-namespace:GymMembers
GymMembers  c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity      GymMembers.View.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1vm"clr-namespace:GymMembers.ViewModel     *localclr-namespace:GymMembers     ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     -   $��
mainWindow��  � Title$  Gym Memberships��$	��350��$	��525�� � DataContext ��    Locator �� Source# [   �� Path$
 Main�.��� ���	#FFECEAEA.+��� -    ��Name$ 	AddButton��$	��Add��$��1��$��1��$
��Left=�$	��Top=�$��75��$��0,50,0,0q����� *
AddCommand+�� -   $ 
ExitButton��$
��Exit��$��1��$��1��$
��Left=�$��Bottom=�$��75��$��0,0,0,50q����� *ExitCommand+����  �� ElementName$ 
mainWindow���� -    ��Name$ ListBox��$��1��$��0��$��Center=�$��Center=�$	��220��$	��322������ *
MemberList+ �� SelectedItem �� *SelectedMember+.  (System.Windows.Interactivity.Interaction   Triggers /  )System.Windows.Interactivity.EventTrigger  	   	EventName$	 MouseUp��.  (System.Windows.Interactivity.TriggerBase
   Actions.
 6  0System.Windows.Interactivity.InvokeCommandAction     Command �� *ChangeCommand+�� -    ��Name$ label��$��
Customers:��$��0��$��0��$
��Left=�$��Bottom=� � ColumnDefinitions �� $	��380 ���  � RowDefinitions �� $��* ��� $	��250 ��� $��* �