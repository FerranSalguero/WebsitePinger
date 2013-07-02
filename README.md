WebsitePinger
=============

This is a simple project to ping websites, it is really useful for websites hosted on IIS servers with low traffic, thinking mainly on my demo projects hosted on **AppHarbor**.

Pinging your website will make the page load much faster for other visitors as starting the worker process on AppHarbor takes its time.

This project can be forked and you can host it in your home server or at AppHarbor. Also there are a few improvements that can be done, listed on the TODO list at the end of the document.

Steps:
1. Fork the project
2. Create or log in into your AppHarbor account
3. Create a new application
4. Connect it to your repository
5. Modify the url list with your own and push the changes to your repository, AppHarbor will then deploy your last commit

That's all!


##TODO

- [ ] Log data, use NLog and config Logentries in web.config
- [ ] Get feedback on offline urls

