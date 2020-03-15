using AssignmentPromact.Models;
using AssignmentPromact.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.Controllers
{
    public class HomeController : Controller
    {
        private IPostsRepository _postsRepository;
        private ICommentsRepository _commentsRepository;
        private readonly AppDbContext _auc;
        
        public HomeController(IPostsRepository postsRepository, ICommentsRepository commentsRepository,AppDbContext auc)
        {
            _postsRepository = postsRepository;
            _commentsRepository = commentsRepository;
            _auc = auc;
        }
       [HttpGet] 
        public ViewResult Index( )
        {
             return View();
        }

        [HttpPost]
      
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
               
                _auc.Add(user);
                _auc.SaveChanges();
                return RedirectToAction("SeePosts");
            }
            else
            {

                return View();
            }
            
        }
        [HttpGet]
        public ViewResult SeePosts()
        {
            var model = _postsRepository.GetAllPosts();
            return View(model);
        }
        [HttpPost]
        public ViewResult SeePosts(Posts psts)
        {
            if (ModelState.IsValid)
            {
                _auc.Add(psts);
                _auc.SaveChanges();
                var model = _postsRepository.GetAllPosts();
                return View(model);
            }
            else
            {
                var model = _postsRepository.GetAllPosts();
                return View(model);
            }
        }

        [HttpGet]
        public ViewResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
             {
                 Posts = _postsRepository.GetPosts(id)
             };
             return View(homeDetailsViewModel);
        }

         [HttpPost]
        public ActionResult Details(Comments cmnts)
        {
            _auc.comments.Add(cmnts);
            _auc.SaveChanges();
           return Redirect($"/Home/Comments/{cmnts.Post_Id}");
        }

           
        public ViewResult Comments(int id)
        {
            var homeCommentsViewModel = _commentsRepository.GetAllComments(id);
             return View(homeCommentsViewModel);
        }
      
        public ViewResult Sharing(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Posts = _postsRepository.GetPosts(id)
            };
            return View(homeDetailsViewModel);
        }
        public ViewResult ShareComment(int id)
        {
            var model = _commentsRepository.GetComments(id);
            return View(model);
        }
        public IActionResult Create()
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Sharing");
            }
        }
      
        public  ActionResult IncrementCount(int id)
        {
             Posts pst = _auc.posts.FirstOrDefault(p => p.Post_Id == id);
            if(pst != null)
            {
                pst.Likes += 1;
                _auc.posts.Update(pst);
                _auc.SaveChanges();
            }
             
                return Redirect($"/Home/SeePosts");
            }
        public ActionResult Likes(int id)
        {
            Comments cmnts = _auc.comments.FirstOrDefault(c => c.Comment_Id == id);
            if(cmnts != null)
            {
                cmnts.Like += 1;
                _auc.comments.Update(cmnts);
                _auc.SaveChanges();
            }
            return Redirect($"/Home/Comments/{cmnts.Post_Id}");
        }
       
    }

}
