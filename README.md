# Image Link Helper for ASP.NET MVC #

**ImageLinkHelper** is a HTML helper for ASP.NET MVC written in C#.

## Features ##

- Image Rollover
- Custom HTML Attributes
- Custom Routing

## Example of Usage ##

> @Html.ImageLink("Register", "Account", null, Url.Content("~/content/images/button-register.png"), Url.Content("~/content/images/button-register-hover.png"), "Register an Account", null, new { style = "margin-right: 15px;" })
