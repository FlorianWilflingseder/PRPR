   M S B A M L   `   `   `  ����T  PQTDrugPrescription.WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:QTDrugPrescription.WpfApp.ViewModels$QTDrugPrescription.WpfApp.ViewModels  5   	   E'clr-namespace:QTDrugPrescription.WpfAppQTDrugPrescription.WpfApp  5   	   )    #QTDrugPrescription.WpfApp.AddWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Avm2clr-namespace:QTDrugPrescription.WpfApp.ViewModels     5   	   9local'clr-namespace:QTDrugPrescription.WpfApp     5   	     � Title$  	AddWindow��5	   	   $	��270��6   $	��600��6(    � DataContext 5
      ;   5QTDrugPrescription.WpfApp.ViewModels.PatientViewModel  5   
   6    .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��10 �6   6,   �� 5      $	��120 �6   6-   �� 5      6!   .+�5   
   �� $��1��6   $��1��6   .��6-   Nummer65   �� 5   
   $��1��6   $��2��6   $��10q�6/   ��6;   ��  �� Path$ SocialSecurityNumber�6h   �� 5   
   $��2��6   $��1��6   .��6-   	Vorname66   �� 5   
   $��2��6   $��2��6   $��10q�6/   ��6;   �� $ 	FirstName�6]   �� 5    
   $��3��6   $��1��6   .��6-   
Nachname67   �� 5!   
   $��3��6   $��2��6   $��10q�6/   ��6;   �� $ LastName�6\   �� 5"   
   $��4��6   $��2��6"   .+�5#      �� -   5        $	��200��5#      ��6$   �� *
CommandAdd+.��6R   	Speichern6]   �� 5$      -   5        $	��200��5$      $��5q�6$   .��6?   Close6F   5%      5&      5(      