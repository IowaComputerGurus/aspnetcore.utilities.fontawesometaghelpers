module.exports = {
    "dataSource": "issues",
    "prefix": "",
    "onlyMilestones": false,
    "ignoreIssuesWith": [
        "question",
        "wontfix",
        "invalid"
    ],
    "groupBy": {
        "Enhancements": ["enhancement", "feature"],
        "Resolved Issues": ["bug" ],
        "Documentation": ["administrative", "documentation"]
    },
    "changelogFilename": "CHANGELOG.md",
    "template": {
        commit: ({ message, url, author, name }) => `- [${message}](${url}) - ${author ? `@${author}` : name}`,
        issue: "- [{{text}}]({{url}}) {{name}}",
        label: "[**{{label}}**]",
        noLabel: "closed",
        group: "\n#### {{heading}}\n",
        changelogTitle: "# Changelog\n\n",
        release: "## {{release}} ({{date}})\n{{body}}",
        releaseSeparator: "\n---\n\n"
    }
}