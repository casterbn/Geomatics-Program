<div align="center">
    <a name="Top"></a>
	<h1>2024测绘程序设计比赛资料</h1>
</div>
<div align="center">
    <img alt="Static Badge" src="https://img.shields.io/badge/QQ-1482275402-red">
    <img alt="Static Badge" src="https://img.shields.io/badge/%E5%BE%AE%E4%BF%A1-lizhengxiao99-green">
    <img alt="Static Badge" src="https://img.shields.io/badge/Email-dauger%40126.com-brown">
    <a href="https://blog.csdn.net/daoge2666/"><img src="https://img.shields.io/badge/CSDN-论坛-c32136" /></a>
    <a href="https://www.zhihu.com/people/dao-ge-92-60/"><img src="https://img.shields.io/badge/Zhihu-知乎-blue" /></a>
    <img src="https://komarev.com/ghpvc/?username=LiZhengXiao99&label=Views&color=0e75b6&style=flat" alt="访问量统计" />
</div>
<div align="center">
    <a name="Top"></a>
    <br/>
   	<details>
        <summary><strong>2024赛前日程安排（点击展开）</strong></summary>
		<p>
            <img src="https://pic-bed-1316053657.cos.ap-nanjing.myqcloud.com/img/%E8%B5%9B%E5%89%8D%E6%97%A5%E7%A8%8B%E5%AE%89%E6%8E%92.png" alt="赛前日程安排" style="zoom:30%;" />
        </p>
    </details>
    <details>
        <summary><strong>2024年测绘程序设计比赛选题及说明（点击展开）</strong></summary>
		<p>
            <img src="https://pic-bed-1316053657.cos.ap-nanjing.myqcloud.com/img/2024%E5%B9%B4%E7%A8%8B%E5%BA%8F%E8%AE%BE%E8%AE%A1%E6%AF%94%E8%B5%9B%E9%80%89%E9%A2%98%E5%8F%8A%E8%AF%B4%E6%98%8E.png" alt="2024年程序设计比赛选题及说明" style="zoom:30%;" />
        </p>
    </details>
</div>
---

## 相关资料

* [教育部高等学校测绘类专业教学指导委员会通知官网](https://smt.whu.edu.cn/sshd/dxscxcyznds.htm)：比赛通知、结果发布地址；
* [智绘未来B站账号](https://space.bilibili.com/1965733536)：赛前培训直播和录播；
* [测绘程序设计教材](https://pan.baidu.com/s/1zHryU_X0CNb2JY0wjCn9fA?pwd=aust)/[例程](https://github.com/ybli/bookcode)/[配套视频](https://www.bilibili.com/video/BV1Gh411e7ow)：测绘程序设计比赛的官方参考书、参考例程；
* [测绘程序设计比赛讲解-回放](https://www.bilibili.com/video/BV18s4y1y71P/?spm_id_from=333.999.0.0)：23年李英冰老师做的赛题讲解；
* [罗宏昆的23测绘程序设计仓库CeHuiProgramDesign)](https://github.com/luohongk/CeHuiProgramDesign)/[24赛题讲解视频](https://www.bilibili.com/video/BV1VM4m1R7xY/?spm_id_from=333.999.0.0)/[界面设计视频](https://www.bilibili.com/video/BV19x4y127MV)；
* [我22年省赛的界面设计视频](https://pan.baidu.com/s/1XN0B3IF7GJFRDMTwnh73ew?pwd=aust)：可以和罗哥的界面设计视频结合着看。

---

## 国赛六个题

> * 如果您还没接触过 Github，可以看看：[Github上手](https://github.com/LiZhengXiao99/Navigation-Learning/blob/main/%E5%BF%83%E5%BE%97%E4%BD%93%E4%BC%9A/Github%E4%BD%BF%E7%94%A8%E6%8C%87%E5%8D%97.md)、[Git + GitHub 10分钟完全入门](https://www.bilibili.com/video/BV1KD4y1S7FL)。
>
> * Github 不支持直接下载文件夹，如果你想单独下载其中一个项目，可以参考：[Github | 如何在Github上只下载一个文件或文件夹！？](https://zhuanlan.zhihu.com/p/578116206)

1. [**空间数据探索性分析**](01-空间数据探索性分析)：计算标准误差椭圆、空间权重矩阵、常用空间自相关指数。
   
   > **参考例程**：暂无
2. [**遥感图像空间前方交会计算**](02-遥感图像空间前方交会计算)：计算立体像对的投影系数、像空间辅助坐标系坐标及地面摄影测量坐标系坐标。
   
   > **参考例程**：书上的例程有错，可以参考[矿大罗宏昆的 C# 程序](https://github.com/luohongk/CeHuiProgramDesign/tree/main/%E9%81%A5%E6%84%9F%E5%BD%B1%E5%83%8F%E7%9A%84%E7%A9%BA%E9%97%B4%E5%89%8D%E6%96%B9%E4%BA%A4%E4%BC%9A)。
3. [**GNSS空间大气改正计算**](03-GNSS空间大气改正计算)：常用电离层改正模型、对流层改正模型计算。
   
   > **参考例程**：书上给的例程。
4. [**纵横断面计算**](04-纵横断面计算)：道路纵断面、横断面的相关点位计算，以及断面面积计算。
   
   > **参考例程**：22年国赛题，书上例程是 VB 的而且读文件的时候有 BUG（有个换行符写错了），可以参考[矿大罗宏昆的 C# 程序](https://github.com/luohongk/CeHuiProgramDesign/tree/main/%E7%BA%B5%E6%A8%AA%E6%96%AD%E9%9D%A2%E8%AE%A1%E7%AE%97)和[我的22年国赛程序](2022国赛李贵程-李郑骁-纵横断面（国一）)。
5. [**大地线长度计算**](05-大地线长度计算)：根据地球椭球参数和椭球面上的大地经纬度坐标，计算两点之间的大地线长度。
   
   > **参考例程**：书上给的例程，也可以参考大地主题正反算例程，因为大地线长度计算是大地主题反算的一部分。
6. [**曲线拟合**](06-曲线拟合)：利用五点光滑法进行曲线拟合。
   
   > **参考例程**：书上给的例程。

---

### 如何准备测绘程序设计比赛

1. **学C#基础语法**
   * 如果有编程基础，就无需系统的学 C# 语法，看看[C#语言介绍](https://learn.microsoft.com/zh-cn/dotnet/csharp/tour-of-csharp/)，直接看代码，也可以看看我总结的常用 C#&WinForm 语法；
   * 没有语法基础，找一套视频教程学，跟着敲代码，学点基础，建议找 20 小时以内的教程；
   * 不懂的语法，查微软 [MSDN](https://learn.microsoft.com/zh-cn/dotnet/csharp/) 官方文档，不要看 CSDN 之类的论坛上乱七八糟的文章。
2. **学WinForm**
   * 看看微软官方出的[Windows窗体入门](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/?view=netframeworkdesktop-4.8)；
   * 掌握常用的几个控件：**[SaveFileDialog](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/savefiledialog-component-windows-forms?view=netframeworkdesktop-4.8)**、[**OpenFileDialog**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/openfiledialog-component-windows-forms?view=netframeworkdesktop-4.8)、**[DataGridView](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/datagridview-control-windows-forms?view=netframeworkdesktop-4.8)**、**[RichTextBox](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/richtextbox-control-windows-forms?view=netframeworkdesktop-4.8)**、[**TabControl**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/tabcontrol-control-windows-forms?view=netframeworkdesktop-4.8)、[**MenuStrip**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/menustrip-control-windows-forms?view=netframeworkdesktop-4.8)、[**MenuStrip**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/menustrip-control-windows-forms?view=netframeworkdesktop-4.8)、**[StatusStrip](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/statusstrip-control?view=netframeworkdesktop-4.8)**、**[ToolStrip](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/toolstrip-control-windows-forms?view=netframeworkdesktop-4.8)**、**[Button](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/button-control-windows-forms?view=netframeworkdesktop-4.8)**、[**Label**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/label-control-windows-forms?view=netframeworkdesktop-4.8)、[**RadioButton**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/radiobutton-control-windows-forms?view=netframeworkdesktop-4.8)、**[CheckBox](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/checkbox-control-windows-forms?view=netframeworkdesktop-4.8)**、**[GroupBox](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/groupbox-control-windows-forms?view=netframeworkdesktop-4.8)**；
   * 窗体设计看视频教程比较直观，仿照着[罗宏昆的视频](https://www.bilibili.com/video/BV19x4y127MV)、[我的视频](https://pan.baidu.com/s/1XN0B3IF7GJFRDMTwnh73ew?pwd=aust)练一练。
3. **先把一套题学懂**

   * **看懂题目和数据文件**
     
   * **运行例程**，导入数据，计算，记住程序操作逻辑，确认程序能正确运行；
     
   * **看懂例程**：①先看例程的界面设计，用到了哪些控件；②类型定义；③程序初始化，也就是主窗体的构造函数；④文件读取，理清数据文件中的数据与变量的对应关系；⑤对着公式看数据处理的代码，看看与公式符不符合；⑥看结果展示、输出计算报告的代码。
     
   * **模仿例程写一遍**：①自己新建一个项目，②设计界面，③定义用到的类型，④写数据读取代码，⑤写代码展示读取到的数据，⑥照着题目公式敲数据处理代码，⑦写代码展示计算结果，⑧写代码输出计算报告TXT文件。
     
   * **脱离例程写一遍**：按自己的理解来写，写的时候可以看题目，不要看例程，写完之后再跟例程的结果做对照。
4. **总结一套编程模板，比赛的时候按套路来写程序**

   * **设计思想**：花尽量少的时间，尽可能的让程序更有条理、更模块化、更易扩展。

   * **界面设计**：保证在五分钟之内能实现；能在属性栏进行的控件配置就在属性栏做，不要写代码。

     <img src="https://pic-bed-1316053657.cos.ap-nanjing.myqcloud.com/img/6bed8c898685fb89513327654ea263b3.png" alt="6bed8c898685fb89513327654ea263b3" style="zoom:50%;" />

   * **命名风格**：字段和变量小写字母开头，类、函数大写字母开头。

   * **类型定义**：主要就写三个类，创建对应的三个文件，所有字段和方法都写成 Public：

     * **`DataCenter` 类**：一个数据存储类存所有数据，包括，
     * **`Calculate` 类**：
     * **`FileHelper` 类**：`ReadFile()` 函数实现读取文件、`SaveFile()` 函数实现导出计算报告。

   * **全局变量**：写在 `public partial class Form1 : Form` 下面，也就是用 Form1 的字段来实现类似于全局变量的效果。

     * `DataCenter dataCente = new DataCenter();`：存所有数据；
     * ：存生成的计算报告字段；
     * ：标识系统执行状态。

   * **面向过程**：一万行以上的程序才值得好好的进行面向对象设计；程序在三个地方执行：

     * **主窗体构造函数**：点开程序的时候就会执行，可以放一些初始化的代码，。
     * **读取文件按钮的点击事件**：创建 `FileHelper` 类对象，调用其 `ReadFile()` 函数导入数据到 `dataCenter`，显示读到的数据到的数据到窗体控件上。
     * **数据处理按钮的点击事件**：

5. **有闲工夫可以按自己整理的编程模板套路把几个题都练一遍**

6. **装一个离线版MSDN**，除了这个比赛我从来不用C#，语法不一定记得住，比赛时候忘了可以查一下。

7. **配置VS2017快捷键**

---

## 常用 C#&WinForm 语法

> 我是[学导航](https://github.com/LiZhengXiao99/Navigation-Learning)的，主要写 C++，C#除了这个比赛就没用到过，
>
> * C# 语法比 C++ 简单，C++ 比 C# 灵活、性能高；
> * C# 的 List 对应 C++ 的 Vector；
> * C# 的 WinForm 界面设计方式和 C++ Qt 框架类似；

* **基本数据类型**：int、double（小数都用double不用float）；
* [**运算符**](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/)：和其它编程语言一样：[算术运算符](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/arithmetic-operators)、[比较运算符](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/comparison-operators)、[布尔逻辑运算符](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/boolean-logical-operators)、[位运算符和移位运算符](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators)、[相等运算符](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/equality-operators)、
* **语句结构**：循环语句（for、while、do-while）、条件语句（if-else、switch-case）
* **数组**：
* **List 泛型集合**：（我们写程序不在乎性能，所以能用 List 就别用其它数据结构）
* **[类和对象](https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/types/classes)**：
* **异常捕获**：try-catch，提高程序的鲁棒性，，在导入数据的代码都写在 try 里，
* **MessageBox.Show("Test")**：弹出一个对话框，显示你设置字符串，类似于命令行程序中的 Console.WriteLine()、C 语言中的 Printf、C++ 中的 std::cout。    
* **格式化输出**：
* **字符串操作**：
  * **字符串去空格**：可使用 [String.Trim](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.trim)、[String.TrimStart](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.trimstart) 和 [String.TrimEnd](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.trimend) 方法删除任何前导空格或尾随空格。
  * **[字符串分割](https://learn.microsoft.com/zh-cn/dotnet/csharp/how-to/parse-strings-using-split)**：[String.Split](https://learn.microsoft.com/zh-cn/dotnet/api/system.string.split) 方法通过基于一个或多个分隔符拆分输入字符串来创建子字符串数组，
  * **[字符串拼接](https://learn.microsoft.com/zh-cn/dotnet/csharp/how-to/concatenate-multiple-strings#string-literals)**：
  * **字符串-浮点数转换**：
  * **左右对齐**：Padding
* **StreamReader**：
* **StreamWriter**：
* **[主窗体 Form 操作](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/changing-the-appearance-of-windows-forms?view=netframeworkdesktop-4.8)**：
* **控件常用属性**：Text（控制显示内容）、Name（在代码中的对象名）、Dock（定义控件绑定到边缘）、BlackColor（背景颜色）、BackgroundImage（背景图片）、BackgroundImageLayout（背景图片布局）、Visible（控件是否可见）、Enable（控件是否可用）、FlatStyle（设置外观）、Font（字体）、
* **[SaveFileDialog](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/savefiledialog-component-windows-forms?view=netframeworkdesktop-4.8)**：保存文件对话框，
* [**OpenFileDialog**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/openfiledialog-component-windows-forms?view=netframeworkdesktop-4.8)：打开文件对话框，
* **[DataGridView](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/datagridview-control-windows-forms?view=netframeworkdesktop-4.8)**：
* **[RichTextBox](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/richtextbox-control-windows-forms?view=netframeworkdesktop-4.8)**：
* [**TabControl**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/tabcontrol-control-windows-forms?view=netframeworkdesktop-4.8)：
* [**MenuStrip**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/menustrip-control-windows-forms?view=netframeworkdesktop-4.8)：菜单栏，
* **[ToolStrip](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/toolstrip-control-windows-forms?view=netframeworkdesktop-4.8)**：工具条，
* **[StatusStrip](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/statusstrip-control?view=netframeworkdesktop-4.8)**：状态栏，一般放在界面最下面，显示程序的执行状态。
* **[Button](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/button-control-windows-forms?view=netframeworkdesktop-4.8)**：按钮，上面可以显示文字、图片，双击编写它的点击事件函数。
* [**Label**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/label-control-windows-forms?view=netframeworkdesktop-4.8)：标签，主要作用就是在窗体上显示文字。
* 单选框[**RadioButton**](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/radiobutton-control-windows-forms?view=netframeworkdesktop-4.8)、复选框**[CheckBox](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/checkbox-control-windows-forms?view=netframeworkdesktop-4.8)**：checked 属性指示控件是否除以选中状态，常用**[GroupBox](https://learn.microsoft.com/zh-cn/dotnet/desktop/winforms/controls/groupbox-control-windows-forms?view=netframeworkdesktop-4.8)**给控件分组，可以显示一个组名。

---

## 常用代码段

### 1、坐标点类型定义

* 点名、B、L、H

  ```c#
  ```

* 点名、X、Y、Z

  ```c#
  
  ```

* 点名、X、Y

  ```c#
  
  ```

* 点的集合

  ```c#
  
  ```

---

### 2、从数据文件中循环导入坐标点数据



* 导入数据的代码都写在 `try` 中，如果出现啥问题，比如格式出错、选错文件，程序不会因为异常而退出。
* 先创建打开文件对话框 OpenFileDialog 对象，

```c#
try
{
	OpenFileDialog opf = new OpenFileDialog();  // 创建打开文件对话框对象 opf
	opf.Filter = "文本文件|*.txt";				 // 文件类型过滤，只显示 .txt 文件
	opf.Title = "请选择要导入的文件";			  // 显示在打开文件对话框开头的提示词
	if (opf.ShowDialog() == DialogResult.OK)    // 弹出打开文件对话框
	{
		StreamReader sr = new StreamReader(opf.FileName);   // 创建 StreamReader 对象
		data.Points = new List<Point>();
		Point point ;
		string line = sr.ReadLine();
        string[] lines;
        data.PointCount = int.Parse(line);
        
        for (int i = 0; i < data.PointCount; i++)
        {
			lines = sr.ReadLine().Trim().Split(',');
			point = new Point(lines[0], double.Parse(lines[1]), double.Parse(lines[2]),double.Parse(lines[3]));
			data.Points.Add(point);
		}
			MessageBox.Show("导入数据文件成功！");
		}
	else
	{
		MessageBox.Show("文件打开失败！");
	}
}
catch (Exception)
{
	MessageBox.Show("文件导入失败，请重新导入！");
    throw;
}
```

---

### 3、循环显示坐标点数据到 DataGridView

* 在 DataGridView 控件的属性栏先

```c#
dataGridView1.RowCount = data.PointCount;
for (int i = 0; i < data.PointCount; i++)
	{
		dataGridView1.Rows[i].Cells[0].Value = data.Points[i].Name;
		dataGridView1.Rows[i].Cells[1].Value = data.Points[i].X;
		dataGridView1.Rows[i].Cells[2].Value = data.Points[i].Y;
		dataGridView1.Rows[i].Cells[3].Value = data.Points[i].Z;
}
```

---

### 4、导出计算报告

```c#



```

### 5、程序执行状态枚举

* 程序执行状态枚举定义

  ```c#
  ```

* 导入数据的时候重置程序执行状态枚举

  ```c#
  ```

* 进行某一步计算的时候判断程序执行状态枚举

  ```c#
  
  ```

### 6、度分秒DMS、弧度RAD、角度DEG之间的转换

编程进行三角函数计算的时候一般用弧度（例如：0.5π），生活中常使用角度（例如：60°），经纬度坐标常表示成度分秒（例如 30.3241），所以需要进行转换。

* 弧度转角度

  ```c#
  
  ```

* 角度转弧度

  ```c#
  ```

* 

---

### 7、椭球类

大地测量相关的计算很多都基于旋转椭球，

长半球和扁率





---

## 常见问题（欢迎提Issue补充）

* 下载例程了之后，如何在VS2017中打开？

  > * 确保 VS 中安装了 C# 语言和 .NET 环境；
  >
  > * 双击 `.sln` 是打开解决方案，双击 `.csproj` 是打开项目，一个解决方案可以包含多个项目；
  >
  > * 如果双击没反应，尝试去设置打开方式，选择 VS 打开。

* 打开解决方案或项目报错：未能成功构建其中一个或多个项目。

  > * 可能是程序文件夹没解压，Win11 中压缩文件夹可以直接在资源管理器中点开，看着和普通文件很像，很容易就忘了解压；
  > * 点 `.sln` 打开程序失败，可以试试直接点  `.csproj` 打开项目。

* 更改到目标框架

  > * 安照提示点确认，
