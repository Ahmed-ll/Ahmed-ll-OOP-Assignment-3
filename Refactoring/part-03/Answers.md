# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n × m)
- Time (ms) before: **24 ms**
- What did you change? I copied the blocked IDs into a  HashSet<int>  once at the start of  CountBlocked , and the loop now calls  HashSet.Contains , which is O(1) on average. The method signature and the  found  result are unchanged.
- Time complexity after: **O(n + m)**: O(n) to build the set, plus O(m) to check all requests.
- Time (ms) after: **1 ms**

---

## Students

- What was the problem?
	- StudentCatalog.GetAllStudents()  built a  List<Student>  with all 1,000,000 students before returning, even though  Program.cs  only prints the first 3.
	- Almost all of that time and memory was wasted on students that were never used.
- What did you change?
	- I changed the return type to  IEnumerable<Student>  and replaced the list building with  yield return. 
	- Students are now created lazily, one at a time, only when the caller asks for them, so taking 3 students creates only 3 objects.
	- The program still prints the same first 3 students ( printed=3 ).