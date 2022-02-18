using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_QuanTraSua.Models;
using PagedList;

namespace ASP.NET_QuanTraSua.Controllers
{
    public class DSSANPHAMController : Controller
    {
        private Model1 db = new Model1();
        private List<SANPHAM> LaySanPham()
        {
            return db.SANPHAM.OrderByDescending(s => s.TenSP).ToList();
        }
        private bool isNumber(string a)
        {
            if (!string.IsNullOrEmpty(a))
            {
                return true;
            }
            return false;
        }
        // GET: DSSANPHAM
        public ActionResult Index(int? page, string Name, string first, string end)
        {
            var sanpham = LaySanPham();
            int pagesize = 8;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(Name))
            {

                sanpham = sanpham.Where(p => p.TenSP.ToLower().Contains(Name.ToLower())).ToList();
                return View(sanpham.ToPagedList(pageNumber, pagesize));
            }
            try
            {
                if (isNumber(first) && isNumber(end))
                {
                    sanpham = sanpham.Where(p => long.Parse(p.GiaBan) >= long.Parse(first) && long.Parse(p.GiaBan) <= long.Parse(end)).ToList();
                    return View(sanpham.ToPagedList(pageNumber, pagesize));
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Không hợp lệ";

            }
            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
        public ActionResult Details(string id)
        {
            var tra = from tr in db.SANPHAM
                      where tr.MaSP == id
                      select tr;
            return View(tra.Single());
        }
        public ActionResult TraSua(int? page, string Name, string first, string end)
        {
            var sanpham = (from sp in db.SANPHAM
                           join l in db.PHANLOAI on sp.MaLoai equals l.MaLoai
                           where l.TenLoai == "Trà sữa"
                           select sp).ToList();
            int pagesize = 8;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(Name))
            {

                sanpham = sanpham.Where(p => p.TenSP.ToLower().Contains(Name.ToLower())).ToList();
                return View(sanpham.ToPagedList(pageNumber, pagesize));
            }
            try
            {
                if (isNumber(first) && isNumber(end))
                {
                    sanpham = sanpham.Where(p => long.Parse(p.GiaBan) >= long.Parse(first) && long.Parse(p.GiaBan) <= long.Parse(end)).ToList();
                    return View(sanpham.ToPagedList(pageNumber, pagesize));
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Không hợp lệ";

            }
            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
        public ActionResult Tra(int? page, string Name, string first, string end)
        {
            var sanpham = (from sp in db.SANPHAM
                           join l in db.PHANLOAI on sp.MaLoai equals l.MaLoai
                           where l.TenLoai == "Trà"
                           select sp).ToList();
            int pagesize = 8;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(Name))
            {

                sanpham = sanpham.Where(p => p.TenSP.ToLower().Contains(Name.ToLower())).ToList();
                return View(sanpham.ToPagedList(pageNumber, pagesize));
            }
            try
            {
                if (isNumber(first) && isNumber(end))
                {
                    sanpham = sanpham.Where(p => long.Parse(p.GiaBan) >= long.Parse(first) && long.Parse(p.GiaBan) <= long.Parse(end)).ToList();
                    return View(sanpham.ToPagedList(pageNumber, pagesize));
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Không hợp lệ";

            }
            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
        public ActionResult CaPhe(int? page, string Name, string first, string end)
        {
            var sanpham = (from sp in db.SANPHAM
                           join l in db.PHANLOAI on sp.MaLoai equals l.MaLoai
                           where l.TenLoai == "Cà phê"
                           select sp).ToList();
            int pagesize = 8;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(Name))
            {

                sanpham = sanpham.Where(p => p.TenSP.ToLower().Contains(Name.ToLower())).ToList();
                return View(sanpham.ToPagedList(pageNumber, pagesize));
            }
            try
            {
                if (isNumber(first) && isNumber(end))
                {
                    sanpham = sanpham.Where(p => long.Parse(p.GiaBan) >= long.Parse(first) && long.Parse(p.GiaBan) <= long.Parse(end)).ToList();
                    return View(sanpham.ToPagedList(pageNumber, pagesize));
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Không hợp lệ";

            }
            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
        public ActionResult DoAnVat(int? page, string Name, string first, string end)
        {
            var sanpham = (from sp in db.SANPHAM
                           join l in db.PHANLOAI on sp.MaLoai equals l.MaLoai
                           where l.TenLoai == "Đồ ăn vặt"
                           select sp).ToList();
            int pagesize = 8;
            int pageNumber = (page ?? 1);
            if (!String.IsNullOrEmpty(Name))
            {

                sanpham = sanpham.Where(p => p.TenSP.ToLower().Contains(Name.ToLower())).ToList();
                return View(sanpham.ToPagedList(pageNumber, pagesize));
            }
            try
            {
                if (isNumber(first) && isNumber(end))
                {
                    sanpham = sanpham.Where(p => long.Parse(p.GiaBan) >= long.Parse(first) && long.Parse(p.GiaBan) <= long.Parse(end)).ToList();
                    return View(sanpham.ToPagedList(pageNumber, pagesize));
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Không hợp lệ";

            }
            return View(sanpham.ToPagedList(pageNumber, pagesize));
        }
    }
}