# SlugInMVCApplication

Creating a human friendly URL is one of the important goal in content management system. Recently one dev asked me this question. Like he always sees ‘id’ in URL in MVC application which is not human friendly. He mentioned stack-overflow example when explaining issue to me, so let’s discuss about this.
Open stack-overflow page

https://stackoverflow.com/questions/40956081

you will be redirected to 

https://stackoverflow.com/questions/40956081/runtime-exception-thrown-when-stdvector-destructing

Notice the last part in the query, this is nothing but a slug that is being added in URL all the time. I hope you know Stack-Overflow is also build using ASP.NET MVC. Let’s build similar slug and similar behavior in your MVC application.
