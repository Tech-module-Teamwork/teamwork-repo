# Exercises: C# Intro and Basic Syntax

Problems for exercises and homework for the ["Programming Fundamentals Extended" course @ SoftUni](https://softuni.bg/courses/programming-fundamentals).

1. Debit Card Number

Write a program, which receives **4** **integers** on the console and **prints them** in **4-digit debit card format**. See the examples below for the appropriate formatting.

### Examples

<table>
  <tr>
    <td>Input</td>
    <td>Output</td>
  </tr>
  <tr>
    <td>12
433
1
5331</td>
    <td>0012 0433 0001 5331</td>
  </tr>
  <tr>
    <td>9182
4221
12
3</td>
    <td>9182 4221 0012 0003</td>
  </tr>
  <tr>
    <td>812
321
123
22</td>
    <td>0812 0321 0123 0022</td>
  </tr>
</table>


2. Rectangle Area

Write a program, which calculates a **rectangle’s area**, based on its **width** and **height**. The **width** and **height** come as floating point numbers on the console, **formatted to the 2****nd**** character after the decimal point**.

### Examples

<table>
  <tr>
    <td>Input</td>
    <td>Output</td>
  </tr>
  <tr>
    <td>2
7</td>
    <td>14.00</td>
  </tr>
  <tr>
    <td>7
8</td>
    <td>56.00</td>
  </tr>
  <tr>
    <td>12.33
5</td>
    <td>61.65</td>
  </tr>
</table>


3. Miles to Kilometers

Write a program, which **converts** **miles** to **kilometers**. **Format** the output to the **2****nd**** decimal place**.

Note: **1 mile == 1.60934 kilometers**

### Examples

<table>
  <tr>
    <td>Input</td>
    <td>Output</td>
    <td></td>
    <td>Input</td>
    <td>Output</td>
    <td></td>
    <td>Input</td>
    <td>Output</td>
  </tr>
  <tr>
    <td>60</td>
    <td>96.56</td>
    <td></td>
    <td>1</td>
    <td>1.61</td>
    <td></td>
    <td>52.1113</td>
    <td>83.86</td>
  </tr>
</table>


4. Beverage Labels

Write a program, which reads a food product **name**, **volume**, **energy content** **per 100ml** and **sugar content per 100ml**. Calculate the **energy** and **sugar content** for the **given volume** and print them on the console in the following format:

* Name – as per the input

* Volume – **integer**, **suffixed** by "**ml**" (e.g. “**220ml**”)

* Energy content – **integer**, **suffixed** by "**kcal**" (e.g. “**500kcal**”)

* Sugar content – **integer**, **suffixed** by "**g**" (e.g. “**30g**”) 

### Examples

<table>
  <tr>
    <td>Input</td>
    <td>Output</td>
  </tr>
  <tr>
    <td>Nuka-Cola
220
300
70</td>
    <td>220ml Nuka-Cola:
660kcal, 154g sugars</td>
  </tr>
</table>


<table>
  <tr>
    <td>Input</td>
    <td>Output</td>
  </tr>
  <tr>
    <td>Ice Cold Nuka-Cola
250
350
65</td>
    <td>250ml Ice Cold Nuka-Cola:
875kcal, 162.5g sugars</td>
  </tr>
</table>


<table>
  <tr>
    <td>Input</td>
    <td>Output</td>
  </tr>
  <tr>
    <td>Nuka-Cola Quantum
350
600
140</td>
    <td>350ml Nuka-Cola Quantum:
2100kcal, 490g sugars</td>
  </tr>
</table>


5. * Character Stats

Write a program, which **displays information** about a video game character. You will receive their **name**, **current health**, **maximum health**, **current energy** and **maximum energy **on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.

### Examples

<table>
  <tr>
    <td>Input</td>
    <td>Output</td>
    <td></td>
    <td>Input</td>
    <td>Output</td>
  </tr>
  <tr>
    <td>Mayro
5
10
9
10</td>
    <td>Name: Mayro
Health: ||||||.....|
Energy: ||||||||||.|</td>
    <td></td>
    <td>Bauser
10
10
10
10</td>
    <td>Name: Bauser
Health: ||||||||||||
Energy: ||||||||||||</td>
  </tr>
</table>


<table>
  <tr>
    <td>Input</td>
    <td>Output</td>
    <td></td>
    <td>Input</td>
    <td>Output</td>
  </tr>
  <tr>
    <td>Loogi
8
20
2
14</td>
    <td>Name: Loogi
Health: |||||||||............|
Energy: |||............|</td>
    <td></td>
    <td>Toad
0
5
0
10</td>
    <td>Name: Toad
Health: |.....|
Energy: |..........|</td>
  </tr>
</table>


### Hints

* You can print a character **multiple** times, using **new string(character, count)**.

