// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

long DividePlayers(int[] skill) {
    Array.Sort(skill);
    var teamSkill = skill[0] + skill[^1];
    var left = 1;
    long answer = skill[0] * skill[^1];
    for (var right = skill.Length - 2; left < right; right--)
    {
        if (skill[left] + skill[right] != teamSkill) return -1;
        answer += (skill[left] * skill[right]);
        left++;
    }

    return answer;
}