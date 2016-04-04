import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class SmokeTests(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_Run_MSPaint(self):
        RunWindowsCommand("mspaint")
        wait(MAP.button_file,30)
    
    def test_002_Draw_Green_Circle(self):
        click(MAP.button_draw_circle)
        click(MAP.button_green_color)
        sleep(1)
        dragDrop(MAP.drag, MAP.drop)
    
    def test_003_Save_Green_Circle_Picture_To_Disk_And_Close_MSPaint(self):
        try:
            os.remove("D:\\TELERIK\\EXAM\\Sikuli\\sikuli_tests\\smoke_tests.sikuli\\circle_image.png")
        except OSError:
            pass
        click(MAP.button_file)
        click(MAP.button_save_as)
        sleep(3)
        type("D:\TELERIK\EXAM\Sikuli\sikuli_tests\smoke_tests.sikuli\circle_image.png")
        sleep(1)
        type(Key.ENTER)
        sleep(1)
        click(MAP.button_close_window)
    
    def test_004_Run_MSPaint_And_Open_Green_Circle_Picture(self):
        RunWindowsCommand("mspaint")
        wait(MAP.button_file,30)
        click(MAP.button_file)
        click(MAP.button_open_file)
        sleep(3)
        type("D:\TELERIK\EXAM\Sikuli\sikuli_tests\smoke_tests.sikuli\circle_image.png")
        sleep(1)
        type(Key.ENTER)
    
    def test_005_Validate_Green_Circle_Picture_Exists_And_Close_MSPaint(self):
        sleep(2)
        wait("circle_image.png", 30)
        assert(exists("circle_image.png"))
        click(MAP.button_close_window)
    
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SmokeTests)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='SmokeTests Report' )
    runner.run(suite)
    outfile.close()

