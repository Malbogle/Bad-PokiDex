   M S B A M L   `   `   `  ����B  >Pokedex, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Pokedex.ConvertersPokedex.Converters  5      !    Pokedex.Views.AbilitiesView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1conv clr-namespace:Pokedex.Converters     5        � 	Resources  5	      -   'Pokedex.Converters.DivWidthBy2Converter   DivWidthBy2 �� 
TargetType �� Property �� Value �� 
TargetType �� TextAlignment��%C  &	        '��      '��       5
   
   6$   �� 5   
   " ��6   .�5      ��  � �� �#FFDE006+   �� 5       � ��$ 5q�6'   �� 5       � ��$4 ./Pokedex;component/Resources/Fonts/#Simplifica)�6+   �� 5       � ��$ 25(�6)   �� 5       � ��$ Light"�6+   5      �� 5   
   " ��6   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6$   $
 Left=�5   $   $4��./Pokedex;component/Resources/Fonts/#Simplifica)�5   $   $��35(�5   $   $
��Bold"�5   $   5      5      5      5       .��5!      � ���#003a70 � ColumnDefinitions 5"   
   �� 5#      �� 5$      �� 5%      �� 5&      $��50 �6   �� 5'      �� 5(      �� 5)       � RowDefinitions 5+   
   �� 5,      �� 5-      �� 5.      �� 5/      �� 50      �� 51      �� 52      .+�55   
   �� $(��"/Resources/Images/AllAbilities.png��6   $��8��56      �� 58   
   $��1��6   $��2��6!   $��Learnt Level-Up��65     PokemonSolid#��[ 59      $ Center=�5:      $��Bottom=�5;      $��25(�5<      �� 5=   
   $��4��6   $��2��6$   $��1��68   $��Learnt Alt Ways��5>      #��[ 5?      $ Center=�5@      $��Bottom=�5A      $��25(�5B      �� 5D   
   -   5        $��lvlUpListView��5E   $   $��3��5D      $��2��6'   $��4��5E      ��5F      �� *%#CurPokemonDisplaying.LvlUpAbilities+ �� View 5H      �� 5I      .P�5J      �� $��Ability��6%   	 �� Width	 5K   %   �� 
 �� ElementName$
 lvlUpListView�� �� Path$ ActualWidth� �� 	Converter# [   �� DisplayMemberBinding 5N   %   �� *	Move.Name+�� 5O      $��Level��6%   	 64   �� $
 lvlUpListView��$ ActualWidth�# [   5R   %   �� *+)Version_group_details[0].Level_learned_at+5S      5U      �� 5W   
   $��4��6   $��3��6#   $��2��67   $��4��5X      ��5Y      �� *%#CurPokemonDisplaying.OtherAbilities+ 5\      �� 5]      .P�5^      �� $��Ability��6%   	 5_   %   �� $
 lvlUpListView��$ ActualWidth�# [   5b   %   �� *	Move.Name+�� 5c      $��Method��6%   	 5d   %   �� $
 lvlUpListView��$ ActualWidth�# [   5g   %   �� *1/Version_group_details[0].Move_learn_method.Name+5h      5j      5l      5m      