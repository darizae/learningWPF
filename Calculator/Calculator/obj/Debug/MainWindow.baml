   M S B A M L   `   `   `  ????E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	     ? Title$  Taschenrechner??5   	   $	??500??6    $	??400??6-    ? 
ResizeMode$ NoResize=?69    ? WindowStartupLocation$ CenterScreen=?6O   .??5	      ? 
???????$
??Left=?6   $	??400??69    ? RowDefinitions 5
   
   ?? 5      $??2* ?6   6*   ?? 5      $??1* ?6   6*   .+?5   
   ?? $??Ausgabewerte??6   5      ?? 5   
   $??1??6   $??Operationen??6    5      ? 5   
   ? 5   
   $??0??6   .+?5      ?? -   5         ??Name$ list_box??5      5      ? 5   
   $??1??6   .+?5      	? -   5         	?Name$ rb_tan??5   9    	? 	GroupName$ rechnenoperationen??6   $	??tan??6I   $
??Left=?6W   $??	20,39,0,0q?6r   $	??Top=?6?   	? 5      -   5        $ rb_pot??5   9   $ rechnenoperationen??6   $??e??6I   $
??Left=?6U   $??	71,39,0,0q?6p   $	??Top=?6?   	? 5      -   5        $ rb_sin??5   9   $ rechnenoperationen??6   $	??sin??6I   $
??Left=?6W   $??	20,59,0,0q?6r   $	??Top=?6?   	? 5      -   5        $ rb_root??5   9   $ rechnenoperationen??6   $	??√??6J   $
??Left=?6V   $??	71,59,0,0q?6q   $	??Top=?6?   ?? 5      -   5         ??Name$ 
eingabe_tf??5      $
??Left=?6*   $??
254,56,0,0q?6E    ?? TextWrapping$
 Wrap=?6Y   $	??0.0??6m   $	??Top=?6x   $	??120??6?   ?? 5      -   5        	 ??Name$	 btn_eq??5      $??=??6%   $
??Left=?61   $??
254,83,0,0q?6L   $	??Top=?6`   $
??Bold"?6x   $??54??6?   $??15(?6?   6?   ?? 5      -   5        $	 btn_c??5      $	??C  ??6$   $
??Left=?62   $??
314,83,0,0q?6M   $	??Top=?6a   $
??Bold"?6y   $??60??6?   $??15(?6?   6?   ?? 5      -	   5        
 ??Name$
 
ausgabe_lb??5      $	??0.0??6(   $
??Left=?66   $??
295,25,0,0q?6Q   $	??Top=?6e    J? RenderTransformOrigin$ 0.011,-0.095&?6}   5       5!      5"      