   M S B A M L   `   `   `  ����B  >Pokedex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PokedexPokedex  5   	   -clr-namespace:Pokedex.ViewsPokedex.Views  5   	   7 clr-namespace:Pokedex.ViewModelsPokedex.ViewModels  5   	       Pokedex.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Pokedex     5   	   -viewsclr-namespace:Pokedex.Views     5   	   7
viewModels clr-namespace:Pokedex.ViewModels     5   	     � Title$  
MainWindow��5
   	   $	��800��6   $	��700��6)    � 	Resources 5       �� DataType)  #Pokedex.ViewModels.PokemonViewModel   Pokedex.Views.PokemonView*   $Pokedex.ViewModels.AblitiesViewModel!   Pokedex.Views.AbilitiesView��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      � ���#003a70 � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� ��6   �� *CurViewModel+�� 5    
   $��1��6   $7��1/Pokedex;component/Resources/Fonts/#Pokemon Solid)�5"      $��18(�5#      ���#ffcb05��5!      �� *NavToAbilities+ 5%       �� 
TargetType �� Property �� Value��%�   '��       �� 5&      " ��6   .�5'      ��  �@��CornerRadius$ 10��65   �� 5(       � ��
 �   �64   5*      5+      ��5,      �� 5-      " ��6   .�5.      ��  � ��$ View Abiltities!��60    �� Triggers 5/      �� 50      	 �� Binding	 6&   �� *	CurPage+
 �� Value
 True6B   .a�51      ��  � ��$ 
Back Home!��68   52      54      56      59      5:      