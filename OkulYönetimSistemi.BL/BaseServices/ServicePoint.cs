using System;
using System.Collections.Generic;
using OkulYönetimSistemi.BL.DataServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimSistemi.BL.BaseServices
{
    public class ServicePoint
    {
        //yeni bir nesne türetme sınıfı

        private AnswerService answerService;
        private AttendanceService attendanceService;
        private ClassLectureService classLectureService;
        private ClassService classService;
        private ExamService examService;
        private ExamReportService examReportService;
        private LectureService lectureService;
        private QuestionService questionService;
        private StudentService studentService;
        private TeacherService teacherService;

        public AnswerService AnswerService { get {return answerService ?? new AnswerService(); } }
        public AttendanceService AttendanceService { get { return attendanceService ?? new AttendanceService(); } }
        public ClassLectureService ClassLectureService { get { return classLectureService ?? new ClassLectureService(); } }
        public ClassService ClassService { get { return classService ?? new ClassService(); } }
        public ExamService ExamService { get { return examService ?? new ExamService(); } }
        public ExamReportService ExamReportService { get { return examReportService ?? new ExamReportService(); } }
        public LectureService LectureService { get { return lectureService ?? new LectureService(); } }
        public QuestionService QuestionService { get { return questionService ?? new QuestionService(); } }
        public StudentService StudentService { get { return studentService ?? new StudentService(); } }
        public TeacherService TeacherService { get { return teacherService ?? new TeacherService(); } }
    }
}
