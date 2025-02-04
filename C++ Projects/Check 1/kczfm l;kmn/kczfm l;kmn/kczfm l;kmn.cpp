// kczfm l;kmn.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
int add(int num1, int num2) {
    return num1 + num2;
}
int divid(int num1, int num2) {
    return num1 / num2;
}
void mul(int num1, int num2, int &output) {
    output = num1 * num2;
}
int main()
{
    int r = 89;
    int t = 77;
    int y = add(r, t);
    std::cout << y << "\n";
    int w = 60;
    int e = 2;
    int q = divid(w, e);
    std::cout << q;
    int f = 87;
    int g = 65;
    int m;
    mul(f, g, m);
    std::cout << "\n" << m;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
