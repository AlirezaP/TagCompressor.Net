# TagCompressor.Net
TagCompressor.Net is a Mvc Attribute For Tag Comressing<br/>

Example:<br/>
this a view without tagcompressor:<br/>

        public ActionResult Index()
        {
            return View();
        }
        
        output:
        
        
      <!DOCTYPE html>
      <html>
      <head>
          <meta charset="utf-8" />
          <meta name="viewport" content="width=device-width, initial-scale=1.0">
          <title>Home Page - My ASP.NET Application</title>
          <link href="/Content/bootstrap.css" rel="stylesheet"/>
      <link href="/Content/site.css" rel="stylesheet"/>

          <script src="/Scripts/modernizr-2.6.2.js"></script>


      </head>
      <body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="/">Application name</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li><a href="/">Home</a></li>
                    <li><a href="/Home/About">About</a></li>
                    <li><a href="/Home/Contact">Contact</a></li>
                </ul>
                    <ul class="nav navbar-nav navbar-right">
        <li><a href="/Account/Register" id="registerLink">Register</a></li>
        <li><a href="/Account/Login" id="loginLink">Log in</a></li>
    </ul>

            </div>
        </div>
    </div>
    <div class="container body-content">
        

      .
      .
      .

      </body>
      </html>

<br/>

with tagcompressor:<br/>

        [TagCompressor.Net.Compress]
        public ActionResult Index()
        {
            return View();
        }
        
        output:
        
        <!DOCTYPE html> <html> <head> <meta charset="utf-8" /> <meta name="viewport" content="width=device-width, initial-scale=1.0"> <title>Home Page - My ASP.NET Application</title> <link href="/Content/bootstrap.css" rel="stylesheet"/> <link href="/Content/site.css" rel="stylesheet"/> <script src="/Scripts/modernizr-2.6.2.js"></script> </head> <body> <div class="navbar navbar-inverse navbar-fixed-top"> <div class="container"> <div class="navbar-header"> <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse"> <span class="icon-bar"></span> <span class="icon-bar"></span> <span class="icon-bar"></span> </button> <a class="navbar-brand" href="/">Application name</a> </div> <div class="navbar-collapse collapse"> <ul class="nav navbar-nav"> <li><a href="/">Home</a></li> <li><a href="/Home/About">About</a></li> <li><a href="/Home/Contact">Contact</a></li> </ul> <ul class="nav navbar-nav navbar-right"> <li><a href="/Account/Register" id="registerLink">Register</a></li> <li><a href="/Account/Login" id="loginLink">Log in</a></li> </ul> </div> </div> </div> <div class="container body-content"> <div class="jumbotron"> <h1>ASP.NET</h1> <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p> <p><a href="http://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p> </div> <div class="row"> <div class="col-md-4"> <h2>Getting started</h2> <p> ASP.NET MVC gives you a powerful, patterns-based way to build dynamic websites that enables a clean separation of concerns and gives you full control over markup for enjoyable, agile development. </p> <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301865">Learn more &raquo;</a></p> </div> <div class="col-md-4"> <h2>Get more libraries</h2> <p>NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.</p> <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301866">Learn more &raquo;</a></p> </div> <div class="col-md-4"> <h2>Web Hosting</h2> <p>You can easily find a web hosting company that offers the right mix of features and price for your applications.</p> <p><a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301867">Learn more &raquo;</a></p> </div> </div> <hr /> <footer> <p>&copy; 2016 - My ASP.NET Application</p> </footer> </div> <script src="/Scripts/jquery-1.10.2.js"></script> <script src="/Scripts/bootstrap.js"></script> <script src="/Scripts/respond.js"></script> </body> </html> 
