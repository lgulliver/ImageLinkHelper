# Image Link Helper for ASP.NET MVC #

**ImageLinkHelper** is a HTML Helper for MVC to provide Image links with all that lovely Razor syntax. It's written in C#.

## Features ##

- Image Rollovers
- Custom HTML Attributes
- Custom Routing

## Example Usage ##

```
@Html.ImageLink("Register", "Account", null, Url.Content("~/content/images/button-register.png"), Url.Content("~/content/images/button-register-hover.png"), "Register an Account", null, new { style = "margin-right: 15px;" })
```
