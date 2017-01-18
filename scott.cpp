class Widget{
    public:
        // default ctor
        Widget();                                   
        // std::initializer_list ctor
        Widget(std::initializer_list<int> il);      
}; 

Widget w1;      // calls default ctor
Widget w2{};    // also calls default ctor
Widget w3();    // most vexing parse! declares a function!    

Widget w4({});  // calls std::initializer_list ctor with empty list
Widget w5{{}};  // ditto  -- ... not so fast Dr. Meyers
