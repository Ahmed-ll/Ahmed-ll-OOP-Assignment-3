# Part 02 — answers

---

## Reports

- What was the problem? 
	- CsvReportExporter, JsonReportExporter and  TextReportExporter each contained a full copy of the same algorithm Only  Format  was different.

- What did you change?
	- I created an abstract class  ReportExporter  that holds the export steps and their order in one place.
	- the shared  Load ,  Validate  and  Save  as private methods.
	- Format  is the only  protected abstract  method.
	- Each exporter now inherits from  ReportExporter  and contains only its own  Format. 

- Why did you choose that approach?
	- I used the Template Method pattern with an abstract class instead of an interface.
	- The exporters share both a fixed algorithm and the real implementation of most of its steps.
	- An abstract class can hold that shared code and the step order in one place, and leave only  Format  for subclasses to fill in.

---

## Enrollment

What was the problem?
	 - Program.cs  had to create four services and call them in the correct order to enroll a student.
	 - This duplicated the workflow across callers and made changes harder.

What did you change?
	- I added an  EnrollmentFacade  with a single  Enroll(studentId, courseId, amount)  method that coordinates all four services.
	- Program.cs  now uses one call, with no changes to the existing services or output.

Why did you choose that approach?
	- The Facade pattern simplifies the interface by hiding service coordination, execution order, and data flow in one place.