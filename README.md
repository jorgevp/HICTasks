# HICTasks

Requirements:
Docker desktop
Visual studio 2019

Visual Studio:
1. Tools > Options > Container Tools : Run containers on project open = true
2. Open HICTasks.sln
3. Solution Explorer > Right click Properties of HICTasks > Debug > Profile > Docker
4. Build and Run
5. In another Visual studio: Open CreateCertRequest.sln
6. Update Location of the client certificate in line 18
7. Update host container in line 22. 
8. set a breakpoint in line 26
9. Build and run.
10. Step over to line 33 to see result.
