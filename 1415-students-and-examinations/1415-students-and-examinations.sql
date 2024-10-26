/* Write your T-SQL query statement below */
select stu.student_id,stu.student_name,sbj.subject_name,count(exam.subject_name) as attended_exams
 from Students stu
  cross join Subjects sbj
   left join Examinations exam on stu.student_id =exam.student_id and sbj.subject_name =exam.subject_name 
   group by stu.student_id,stu.student_name, sbj.subject_name
   order by stu.student_id, sbj.subject_name;
