domains

menu_type = buyer; seller
action = sale; buy; exchange
state = new; old

predicates

product(string, string, real, integer, action, state)
write_prod(string, string, real, integer, action, state)
select(integer)
menu_settings(menu_type, string, string, integer, integer)
menu(menu_type)
test_type(menu_type, action)
menu_action(integer, menu_type)

clauses

product("Product1",  "household equipment",       58, 2003, sale,      new).
product("Product2",  "refrigerators",             30, 2006, buy,       old).
product("Product3",  "gas and electric stoves",   45, 2005, sale,      new).
product("Product4",  "microwave stoves",         100, 2004, buy,       old).
product("Product5",  "dishwashers",              300, 2009, exchange,  new).
product("Product6",  "kitchen hoods",            245, 2018, buy,       old).
product("Product7",  "microwave stoves",         345, 2011, buy,       new).
product("Product8",  "kitchen hoods",           3244, 1996, buy,       old).
product("Product10", "microwave stoves",          12, 1999, exchange,  old).
product("Product11", "gas and electric stoves",  444, 2014, exchange,  old).
product("Product12", "microwave stoves",        4242, 2000, buy,       new).
product("Product13", "gas and electric stoves",  334, 2013, sale,      new).
product("Product14", "household equipment",       45, 2015, buy,       old).
product("Product15", "kitchen hoods",            987, 2016, exchange,  new).
product("Product16", "refrigerators",           7696, 2016, sale,      old).
product("Product17", "household equipment",      123, 2019, exchange,  old).
product("Product18", "gas and electric stoves",   21, 2014, sale,      new).
product("Product19", "kitchen hoods",           3232, 2002, exchange,  new).
product("Product20", "microwave stoves",         992, 2001, sale,      new).

write_prod(Name, Category, Price, Year, Action, State):-
  write(Name),
  write(", "),
  write(Category),
  write(", $"),
  write(Price),
  write(", "),
  write(Year),
  write(", "),
  write(Action),
  write(", "),
  write(State),
  nl.

%enter number 1..7
select(X):-
  inkey(C),
  char_int(C,N),
  X = N-'0',
  X >= 1,
  X <= 7, !.
select(X):- !, select(X).

menu_settings(buyer, "Buyer menu", "1. Switch to seller menu", $3f, $3e).
menu_settings(seller, "Seller menu", "1. Switch to buyer menu", $6f, $6e).

menu(Type):-
  menu_settings(Type, Title, MenuString, Color1, Color2),
  makewindow(2, Color1, Color2, Title, 6,12,11,55),
  write(MenuString),nl,
  write("2. Search by name"),nl,
  write("3. Search by category"),nl,
  write("4. Search by price"),nl,
  write("5. Search by year of manufacture"),nl,
  write("6. Search by state"),nl,
  write("7. Exit"),
  select(X),
  removewindow(2,1),
  menu_action(X,Type).

%enabled action for menu type
test_type(buyer, sale).
test_type(buyer, exchange).
test_type(seller, buy).
test_type(seller, exchange).

menu_action(7,_):- !. %exit

menu_action(1,buyer):- !, menu(seller). %switch menu type
menu_action(1,seller):- !, menu(buyer).

menu_action(2,Type):-
  clearwindow,
  makewindow(2,$1f,$1e,"Search by name",0,0,25,80),
  write("Name: "),
  readln(Name),
  product(Name, Category, Price, Year, Action, State),
  test_type(Type, Action),
  write_prod(Name, Category, Price, Year, Action, State),
  fail.

menu_action(3,Type):-
  clearwindow,
  makewindow(2,$1f,$1e,"Search by category",0,0,25,80),
  write("Category: "),
  readln(Category),
  product(Name, Category, Price, Year, Action, State),
  test_type(Type, Action),
  write_prod(Name, Category, Price, Year, Action, State),
  fail.

menu_action(4,Type):-
  clearwindow,
  makewindow(2,$1f,$1e,"Search by price",0,0,25,80),
  write("Minimal price: "),
  readreal(MinPrice),
  write("Maximal price: "),
  readreal(MaxPrice),
  product(Name, Category, Price, Year, Action, State),
  test_type(Type, Action),
  Price >= MinPrice,
  Price <= MaxPrice,
  write_prod(Name, Category, Price, Year, Action, State),
  fail.

menu_action(5,Type):-
  clearwindow,
  makewindow(2,$1f,$1e,"Search by year of manufacture",0,0,25,80),
  write("Year of manufacture: "),
  readln(Category),
  product(Name, Category, Price, Year, Action, State),
  test_type(Type, Action),
  write_prod(Name, Category, Price, Year, Action, State),
  fail.

menu_action(6,Type):-
  clearwindow,
  makewindow(2,$1f,$1e,"Search by state",0,0,25,80),
  write("State (new/old): "),
  readterm(state,State),
  product(Name, Category, Price, Year, Action, State),
  test_type(Type, Action),
  write_prod(Name, Category, Price, Year, Action, State),
  fail.

menu_action(_,Type):- 
  write("Press any key..."),
  readchar(_),
  removewindow(2,1), !,
  menu(Type).

goal
  makewindow(1,$0f,$0e,"Information system",0,0,25,80),
  menu(buyer),
  removewindow(1,1).
