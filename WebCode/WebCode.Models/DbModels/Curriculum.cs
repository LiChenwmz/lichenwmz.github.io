using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCode.Models
{
    /// <summary>
    /// 课程
    /// </summary>
    [Table("Curriculum")]//在Models中指定表名可以不让DbEntities自动生成表
    public class Curriculum 
    {
        public int Id { get; set; }
        [DisplayName("名称"), Required]
        public string Name { get; set; }
        [DisplayName("作者"), Required]
        public string Authors { get; set; }
        [DisplayName("简介"), Required]
        public string Synopsis { get; set; }
        [DisplayName("图片")]
        public string Photo { get; set; }
        [DisplayName("描述")]
        public string Describe { get; set; }
        [DisplayName("类别"), Required]
        public int GenreId { get; set; }
        [DisplayName("价格")]
        public Decimal Price { get; set; }
        [DisplayName("状态")]
        public int State { get; set; }
        [DisplayName("是否显示"), Required]
        public int IsDispay { get; set; }
        [DisplayName("添加人"), Required]
        public int AddUser { get; set; }
        [DisplayName("添加时间"), Required]
        public DateTime AddTime { get; set; }
        [DisplayName("变更人")]
        public int? ChangeUser { get; set; }
        [DisplayName("变更时间")]
        public DateTime? ChangeTime { get; set; }
        [DisplayName("点击量")]
        public int? ClickNo { get; set; }
        [DisplayName("购买量")]
        public int? BuyNo { get; set; }
        [DisplayName("课时数")]
        public int? Video { get; set; }
        [DisplayName("发布人")]
        public string AddUserName { get; set; }
        [DisplayName("课程时长")]
        public string VideoTimeCount { get; set; }
    }


}
