# Game 8 digits

* * *

## Breadth First Search (BFS)

*   ### Instructions:

    1.  Cho trạng thái Start vào Open (Queue)
    2.  Nếu Open rỗng thì kết thúc chương trình, tìm kiếm thất bại
    3.  Lấy trạng thái đầu trong Open ra, gọi là O, cho O vào trong Closed (Dictionary)
    4.  Nếu O là trạng thái đích (Goal) thì kết thúc chương trình, tìm kiếm thành công
    5.  Tìm tất cả các trạng thái con của O không thuộc Open và Closed cho vào **cuối** Open
    6.  Trở lại bước 2
*   ### Algorithm Complexity:

    *   Time complexity: O(b^d)
    *   Space complexity: O(b^d)

    **b:** branchs (số nhánh con tối đa của 1 trạng thái)

    **d:** depth (độ sâu của đồ thị)

## Depth-First Search (DFS)

*   ### Instructions:

    1.  Cho trạng thái Start vào Open (Stack)
    2.  Nếu Open rỗng thì kết thúc chương trình, tìm kiếm thất bại
    3.  Lấy trạng thái đầu trong Open ra, gọi là O, cho O vào trong Closed (Dictionary)
    4.  Nếu O là trạng thái đích (Goal) thì kết thúc chương trình, tìm kiếm thành công
    5.  Tìm tất cả các trạng thái con của O không thuộc Open và Closed cho vào **đầu** Open
    6.  Trở lại bước 2
*   ### Algorithm Complexity:

    *   Time complexity: O(b^d)
    *   Space complexity: O(b^d)

    **b:** branchs (số nhánh con tối đa của 1 trạng thái)

    **d:** depth (độ sâu của đồ thị)