import re
import sys
test_cases = open(sys.argv[1], 'r')
for test in test_cases:
    reg=re.compile('\w+@\w+\.\w+')
    match=re.match(reg,test)
    if match:
        print 'true'
    else:
        print'false'

test_cases.close()
