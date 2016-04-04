import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class SmokeTests(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_Navigate_To_Google_Search(self):
        RunBrowserToUrl("iexplore","http://www.google.com")
        wait(MAP.google_search,30)
    
    def test_002_Search_For_Telerik_Academy(self):
        type("Telerik academy")
        type(Key.ENTER)
        wait(MAP.verify_telerik_academy, 30)
        assert(exists(MAP.verify_telerik_academy))
        click(MAP.close)
    
    def test_003_Navigate_To_Drag_And_Drop_Test_Page(self):
        RunBrowserToUrl("iexplore","http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html")
        wait(MAP.veryfy_countries, 30)
        sleep(5)
        dragDrop(MAP.oslo, MAP.norway)
        dragDrop(MAP.copenhagen, MAP.denmark)
        dragDrop(MAP.washington, MAP.unitedstates)
        dragDrop(MAP.madrid, MAP.spain)
        dragDrop(MAP.rome, MAP.italy)
        dragDrop(MAP.seoul, MAP.southkorea)
        dragDrop(MAP.stockholm, MAP.sweden)
        wait(MAP.veryfy_countries_and_capitals, 30)
        assert(exists(MAP.veryfy_countries_and_capitals))
        click(MAP.close)
    
    def test_004_Open_Several_Firefox_Browsers(self):
        openApp("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe")
        sleep(1)
        openApp("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe")
        sleep(1)
        openApp("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe")
        sleep(1)
        openApp("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe")
        sleep(1)
        openApp("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe")
        sleep(3)
    
    def test_005_Minimize_All_Windows(self):
        while(exists(MAP.minimize)):
            click(MAP.minimize)
            sleep(1)
    
    def test_006_Start_Windows_Calculator(self):
        RunWindowsCommand("calc")
        wait(MAP.verify_calculator, 30)
        
    def test_007_Add_Numbers(self):
        click(MAP.digit_six)
        click(MAP.operator_add)
        click(MAP.digit_six)
        click(MAP.digit_zero)
        click(MAP.operator_equals)
        assert(exists(MAP.result_sixty_six))
        click(MAP.clear_calculator)
        
    def test_008_Subtract_Numbers(self):
        click(MAP.digit_one)
        click(MAP.digit_three)
        click(MAP.operator_subtract)
        click(MAP.digit_four)
        click(MAP.operator_equals)
        assert(exists(MAP.result_nine))
        click(MAP.clear_calculator)
        
    def test_009_Multiply_Numbers(self):
        click(MAP.digit_six)
        click(MAP.operator_multiply)
        click(MAP.digit_one)
        click(MAP.digit_zero)
        click(MAP.operator_equals)
        assert(exists(MAP.result_sixty))
        click(MAP.clear_calculator)
        
    def test_010_Divide_Numbers(self):
        click(MAP.digit_two)
        click(MAP.digit_seven)
        click(MAP.operator_divide)
        click(MAP.digit_three)
        click(MAP.operator_equals)
        assert(exists(MAP.result_nine))
        click(MAP.clear_calculator)
        
    def test_011_Divide_By_Zero(self):
        click(MAP.digit_two)
        click(MAP.digit_seven)
        click(MAP.operator_divide)
        click(MAP.digit_zero)
        click(MAP.operator_equals)
        assert(exists(MAP.result_divide_by_zero))
        click(MAP.close)
        
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report' )
    runner.run(suite)
    outfile.close()

