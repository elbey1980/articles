-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Nov 27, 2019 at 03:53 AM
-- Server version: 5.7.11
-- PHP Version: 5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `articles`
--

-- --------------------------------------------------------

--
-- Table structure for table `article`
--

CREATE TABLE `article` (
  `titre` varchar(100) DEFAULT NULL,
  `texte` varchar(65000) DEFAULT NULL,
  `likes` int(11) NOT NULL DEFAULT '0',
  `dislikes` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `article`
--

INSERT INTO `article` (`titre`, `texte`, `likes`, `dislikes`) VALUES
('Segregation Analyzer: a C#.Net application for calculating residential segregation indices', 'Les indices de ségrégation sont aujourd’hui bien connus et de plus en plus utilisés dans le champ des études urbaines. Cependant, en l’absence d’outils informatiques réellement adaptés, le calcul des indices de ségrégation devient rapidement une opération complexe et longue à réaliser. En outre, les rares applications gratuites dédiées aux calculs des indices sont implémentées dans des systèmes d’information géographique (ArcInfo, ArcView et MapInfo). L’utilisateur qui désire calculer les indices à l’aide de ces applications doit donc disposer du logiciel SIG dans lequel est implémentée l’application, mais aussi le maniement des SIG doit lui être suffisamment familier, soit deux conditions qui peuvent limiter l’utilisation et, de ce fait, la démocratisation des indices de ségrégation résidentielle. C’est pour remédier à cette situation que nous proposons ici une application gratuite et autonome développée en C#.Net – Segregation Analyzer – permettant de calculer facilement et rapidement une quarantaine d’indices de ségrégation (indices unigroupes, intergroupes et multigroupes), et ce quelles que soient les données ou la ville à l’étude. Cette application peut être téléchargée gratuitement sur le site Internet du Laboratoire d’analyse spatiale et d’économie régionale — LASER (http://laser.ucs.inrs.ca/FR/Telechargement.html).', 5, 5),
('C# static analysis framework', 'Abstract: The paper describes static analysis techniques that are used for defect detection in C# programs. The goal of proposed analysis approaches is to catch more defects within an acceptable amount of time. Although the paper contains a description of full analysis cycle, it mainly focuses on special aspects that distinguish C# analysis approaches from well-known Java and C++ techniques. The paper illustrates methods that allow taking into account C# specialties of all analysis stages: call graph and control flow graph construction, data flow analysis, context- and path-sensitive interprocedural analysis. We propose an adaptation of symbolic execution methods inspired by Bounded Model Checking and Saturn Software Analysis Project. The paper also explains the organization of memory model, which is suitable for both a precise intraprocedural analysis and a creation of compact function-bound conditions used for interprocedural analysis. Special attention is paid to optimization of condition size and simplicity during a path sensitive-analysis. The conditions produced by a path-sensitive analysis are supposed to be solved by modern SMT solvers like Microsoft Z3 Prover. Different approaches to external functions modeling are covered. All proposed approaches are implemented in the SharpChecker static analysis tool and, as evaluated on several open source C# projects of varying size (1K - 1.35M lines of code), display good results and scalability.', 7, 7),
('Path-sensitive bug detection analysis of C# program illustrated by null pointer dereference', 'Abstract: This paper proposes an approach for detecting bugs in C# programs and uses null pointer deference as the main example. The approach employs a scalable path-sensitive analysis, which involves symbolic execution with state merging and function summary methods. C/C++ program analyzers like Saturn Software Analysis Project, Calysto or Svace use similar approaches. We analyze functions in backward topological order with account for previously calculated summaries. For summary construction, we use the same analysis engine as for bug detection. The paper contains a formal description of the proposed approach applied to reduced “sugar-free” subset of C# language. For each instruction of the considered language, we define a formal semantics and transfer function according to the symbolic state. During the path-sensitive analysis, we store additional information related to possible bugs in the symbolic state, and the decision whether the warning should be reported is made upon the satisfiability of the corresponding formula. Therefore, we reduce the problem of bug detection to satisfiability of a first-order logical formula defined on atoms, which are arithmetic expressions on function input values. It can be efficiently solved with modern SMT solvers. We have implemented the approach in our Roslyn-based analyzer, called SharpChecker. Evaluation of SharpChecker on open-source commodity applications has shown acceptable scalability and reasonable amount of warnings.', 8, 8),
('Creating and Consuming Generics', 'Generics in C# provide a facility for creating high-performance data structures that are specialized by the compiler based on the types that they use. These so-called parameterized types are created so that their internal algorithms remain the same, but also so that the types of their internal data can differ, based on end user preference.\r\n\r\nIn order to minimize the learning curve for developers, generics in C# are declared in much the same way as they are in C++. Programmers can create classes and structures just as they normally have, and by using the angle bracket notation (< and >) they can specify type parameters. When the class is used, each parameter must be replaced by an actual type that the user of the class supplies.\r\n\r\nIn the following example, create a Stack class where a type parameter, called ItemType, is specified and declared in angle brackets after the class declaration. Rather than forcing conversions to and from the base object type, instances of the generic Stack class will accept the type for which they are created and stores data of that type natively. The type parameter, ItemType, acts as a proxy until that type is specified during instantiation and is used as the type for the internal items array—the type for the parameter to the Push method, and the return type for the Pop method:', 5, 5),
('Implementing a Collection', 'Your ButtonArray class will handle the tasks of holding and organizing your control array through the implementation of a collection. A collection is an object that contains a list of indexed object variables, as well as methods to add, remove, and otherwise manipulate objects in the collection. In this section, you will create a class that inherits from System.Collections.CollectionBase, a class in the .NET Framework that provides much of the functionality required for collections, and implement methods that will provide the required functionality.', 7, 8),
('Introduction', 'The Visual Studio® .NET integrated development environment (IDE) provides numerous tools to help you monitor program execution and locate bugs in your user controls and custom controls. You can use the debugging tools to step through your code line-by-line, to add breakpoints in your code, and use the various debugging windows to monitor execution conditions at run time. Because controls are not stand-alone projects, you must provide a host for your control while debugging. In this article, you will create a simple user control, and then use various debugging techniques. Although this article uses a user control, these techniques are applicable to custom controls and inherited controls as well. See Control Authoring for Windows Forms for more infromation on creating different types of controls.', 9, 10),
('Creating Your User Control', 'You will begin your exploration of control debugging by creating a simple user control: a control with a single button that displays a message box when clicked.\r\n\r\nTo create your user control\r\n\r\nCreate a new Windows Control Library project and name it ControlDemo.\r\nFrom the Windows Forms tab of the Toolbox, add a Button to the design surface of your control.\r\nIn the designer, double-click Button1 (button1 in C#) to open the click event handler for this button and add the following code, which will provide the code for your user control as well as add code that throws an exception at run time.', 0, 0),
('Generics Problem Statement', 'Consider an everyday data structure such as a stack, providing the classic Push() and Pop() methods. When developing a general-purpose stack, you would like to use it to store instances of various types. Under C# 1.1, you have to use an Object-based stack, meaning that the internal data type used in the stack is an amorphous Object, and the stack methods interact with Objects:', 0, 0),
('Connecting to the Database', 'This connection allows you to communicate with the data source from within the Visual Studio® integrated development environment (IDE).\r\n\r\nTo connect to the Northwind sample database in Server Explorer\r\n\r\nIn Server Explorer, establish a data connection to the Northwind sample database. For more information, see Adding New Data Connections in Server Explorer.\r\nSecurity Note Storing connection-string details (such as the server name, user name, and password) can have implications for the security of your application. Using Windows Integrated Security is a more secure way to control access to a database. For more information, see Database Security.\r\nExpand the Northwind data connection in Server Explorer until you can see all the tables.', 0, 0),
('Creating Data Adapters and Connections', 'This step will create the connection and data adapters which are used to connect and exchange data between your application and the data source.\r\n\r\nTo create the data adapters and connections\r\n\r\nDrag the Customers table from Server Explorer onto the form. A connection and data adapter appear in the component tray.\r\nSelect the Connection and set the Name property to dcNorthwind.\r\nSelect the data adapter and set the Name property to daCustomers.\r\nFrom Server Explorer, drag the Orders table onto the form. A second data adapter appears in the component tray.\r\nSelect the new data adapter and set the Name property to daOrders.', 0, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `article`
--
ALTER TABLE `article`
  ADD UNIQUE KEY `titre` (`titre`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
