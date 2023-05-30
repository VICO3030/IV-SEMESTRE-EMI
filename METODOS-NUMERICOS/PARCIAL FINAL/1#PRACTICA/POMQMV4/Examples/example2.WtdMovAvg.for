7,1,1,1000,"Example 2 - Weighted moving average"
"POM-QM for Windows 3.0 Build 11"
2,1,2,0,0,0,0
0,1,0,0,1,0,0
4,#TRUE#,0,0,0,0,0,0
8,4
""
"Demand(y)"
"Time(x)"
"Past period"
"Weight"
"Weights->"
"jan 3"
"jan 10"
"jan 17"
"jan 24"
"jan 31"
"feb 7"
"TOTALS"
"AVERAGE"
4
Weights->, 1  0  0  0  0 
jan 3, .6  100  1  0  .6 
jan 10, .4  120  2  100  20 
jan 17, 0  110  3  112 -2 
jan 24, 0  105  4  114 -9 
jan 31, 0  110  5  107  2.999992 
feb 7, 0  120  6  108  12 
TOTALS, 0  665  21  116  3.999992 
AVERAGE, 0  110.8333  18.47222  0  .9999981 
-1,-1
"done"
"The weight for 1 period ago will be placed on the most recent data. For example, the forecast for Feb 14 will be

.6 * 120 (feb 7 - 1 period ago)
+.4 * 110 (jan 31 - 2 periods ago)"
